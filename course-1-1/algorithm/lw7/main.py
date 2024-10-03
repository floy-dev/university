import pathlib

script_directory = str(pathlib.Path(__file__).parent.resolve())


def main():
    file = open(script_directory + '/file.txt')
    lines = file.readlines()
    is_replaced = False

    if len(lines) <= 3 or len(lines) >= 5:
        is_replaced = copy_and_replace(lines)

    if is_replaced:
        return

    copy_and_delete(lines)


def copy_and_delete(lines):
    lines_count = len(lines)

    if lines_count >= 3:
        del lines[2]

    if lines_count >= 5:
        del lines[3]

    copy_file(lines)


def copy_and_replace(lines):
    is_replaced = False

    if len(lines) >= 3 and len(lines[2]) >= 4 and lines[2][3] == ' ':
        lines[2] = replace_char(lines[2], '0')
        is_replaced = True

    if len(lines) >= 5 and len(lines[4]) >= 4 and lines[4][3] == ' ':
        lines[4] = replace_char(lines[4], '0')
        is_replaced = True

    if not is_replaced:
        return False

    copy_file(lines)

    return True


def copy_file(lines):
    with open(script_directory + '/new_file.txt', 'w') as f:
        for line in lines:
            f.write(line)


def replace_char(string, char):
    modified_string = list(string)
    print(modified_string)
    modified_string[3] = char
    return ''.join(modified_string)


if __name__ == '__main__':
    main()
