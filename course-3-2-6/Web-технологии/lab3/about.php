<?php

function getFiles($folder, $root)
{
    $names = @scandir($folder);
    if ($names === false) {
        return false;
    }

    $files = [];
    foreach ($names as $name) {
        $fullPath = $folder . '/' . $name;
        if ($name === '.' || $name === '..' || is_link($fullPath)) {
            continue;
        }

        $files[] = [
            'path' => substr($fullPath, strlen($root) + 1),
            'isFolder' => is_dir($fullPath)
        ];

        if (is_dir($fullPath)) {
            $children = getFiles($fullPath, $root);
            if ($children === false) {
                return false;
            }
            $files = array_merge($files, $children);
        }
    }

    return $files;
}

function getSize($path)
{
    if (is_file($path)) {
        return filesize($path);
    }

    $names = scandir($path);
    if ($names === false) {
        return false;
    }

    $size = 0;
    foreach ($names as $name) {
        $fullPath = $path . '/' . $name;
        if ($name === '.' || $name === '..' || is_link($fullPath)) {
            continue;
        }

        $fileSize = getSize($fullPath);
        if ($fileSize === false) {
            return false;
        }
        $size += $fileSize;
    }

    return $size;
}

$root = realpath(__DIR__);
$size = null;
$error = '';

if (isset($_GET['path'])) {
    $path = $_GET['path'];
    $fullPath = realpath($root . '/' . $path);

    if ($fullPath === false || ($fullPath !== $root && !str_starts_with($fullPath, $root . '/'))) {
        $error = 'Файл или папка не найдены либо находятся за пределами сайта';
    } elseif (!is_file($fullPath) && !is_dir($fullPath)) {
        $error = 'Можно выбрать только файл или папку';
    } else {
        $size = getSize($fullPath);
        if ($size === false) {
            $error = 'Не удалось прочитать размер выбранного файла или папки';
        }
    }
}

$files = getFiles($root, $root);

?>

<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Свой ход - Размер файлов сайта</title>
</head>
<body>
    <?php if ($error !== ''): ?>
        <p><?= $error ?></p>
    <?php elseif ($size !== null): ?>
        <p>Путь: <strong><?= $path ?></strong></p>
        <p>Размер: <strong><?= number_format($size, 0, ',', ' ') ?> байт</strong></p>
    <?php endif; ?>

    <h2>Файлы и папки</h2>
    <ul style="list-style: none; padding: 0">
        <li><a href="about.php?path=.">[Папка] . — весь сайт</a></li>
        <?php foreach ($files as $file): ?>
            <li style="margin-left: <?= (substr_count($file['path'], '/') + 1) * 24 ?>px">
                <a href="about.php?path=<?= rawurlencode($file['path']) ?>">
                    <?= $file['isFolder'] ? '[Папка]' : '[Файл]' ?>
                    <?= $file['path'] ?>
                </a>
            </li>
        <?php endforeach; ?>
    </ul>
</body>
</html>

