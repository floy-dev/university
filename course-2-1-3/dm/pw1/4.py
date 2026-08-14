def find_paths(matrix, start, path_length):
    matrix_len = len(matrix)
    results = []

    def depth_first_search(current_vertex, current_path, current_length):
        if current_length == path_length:
            results.append([x + 1 for x in current_path])
            return
        for next_vertex in range(matrix_len):
            if matrix[current_vertex][next_vertex] == 1:
                current_path.append(next_vertex)
                depth_first_search(next_vertex, current_path, current_length + 1)
                current_path.pop()

    depth_first_search(start - 1, [start - 1], 0)

    return results


def print_paths(paths):
    for path in paths:
        print(path)


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

start_vertex = 1
input_path_length = 3

print('G1')
print_paths(find_paths(graph_1, start_vertex, input_path_length))

print('G2')
print_paths(find_paths(graph_2, start_vertex, input_path_length))