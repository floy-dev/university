def is_route(matrix, sequence):
    is_route_statement = True
    for i in range(len(sequence) - 1):
        is_route_statement = is_route_statement and matrix[sequence[i] - 1][sequence[i + 1] - 1] == 1
    return is_route_statement


def is_chain(matrix, sequence):
    if not is_route(matrix, sequence):
        return False

    edges = set()

    for i in range(len(sequence) - 1):
        if sequence[i] < sequence[i + 1]:
            edge = (sequence[i], sequence[i + 1])
        else:
            edge = (sequence[i + 1], sequence[i])
        if edge in edges:
            return False
        edges.add(edge)

    return True


def is_simple_chain(matrix, sequence):
    if not is_chain(matrix, sequence):
        return False
    return (len(set(sequence)) == len(sequence)
            or len(set(sequence)) == len(sequence) - 1 and sequence[0] == sequence[-1])


def is_cycle(matrix, sequence):
    return is_route(matrix, sequence) and sequence[0] == sequence[-1]


def is_simple_cycle(matrix, sequence):
    if not is_cycle(matrix, sequence) or not is_simple_chain(matrix, sequence):
        return False
    return len(set(sequence[:-1])) == len(sequence) - 1


def check_path(matrix, sequence):
    return {
        'Маршрут': 'Да' if is_route(matrix, sequence) else 'Нет',
        'Цепь': 'Да' if is_chain(matrix, sequence) else 'Нет',
        'Простая цепь': 'Да' if is_simple_chain(matrix, sequence) else 'Нет',
        'Цикл': 'Да' if is_cycle(matrix, sequence) else 'Нет',
        'Простой цикл': 'Да' if is_simple_cycle(matrix, sequence) else 'Нет'
    }


def print_paths(paths):
    for path in paths:
        print(path, ':', paths[path])


graph_1 = [
    [0, 1, 0, 0, 0, 0, 1],
    [1, 0, 0, 0, 0, 1, 1],
    [0, 0, 0, 1, 1, 1, 0],
    [0, 0, 1, 0, 1, 0, 0],
    [0, 0, 1, 1, 0, 1, 0],
    [0, 1, 1, 0, 1, 0, 1],
    [1, 1, 0, 0, 0, 1, 0]
]

graph_2 = [
    [0, 1, 0, 1, 0, 1, 1],
    [1, 0, 1, 1, 0, 0, 0],
    [0, 1, 0, 1, 1, 1, 0],
    [1, 1, 1, 0, 0, 0, 0],
    [0, 0, 1, 0, 0, 1, 0],
    [1, 0, 1, 0, 1, 0, 1],
    [1, 0, 0, 0, 0, 1, 0]
]

input_sequence = [5, 3, 6, 7, 1, 6, 5]

print('G1')
print_paths(check_path(graph_1, input_sequence))

print('G2')
print_paths(check_path(graph_2, input_sequence))
