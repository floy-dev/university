def depth_first_search(graph, current_vertex, end_vertex, path_length, current_path, all_paths):
    if path_length == 0:
        if current_vertex == end_vertex:
            all_paths.append(current_path.copy())
        return

    for neighbor in range(len(graph[current_vertex])):
        if graph[current_vertex][neighbor] == 1:
            current_path.append(neighbor + 1)
            depth_first_search(graph, neighbor, end_vertex, path_length - 1, current_path, all_paths)
            current_path.pop()


def find_paths(graph, start, end, length):
    all_paths = []

    depth_first_search(graph, start - 1, end - 1, length, [start], all_paths)

    return all_paths


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

first_vertex = 1
second_vertex = 2
input_path_length = 3

print('G1')
print_paths(find_paths(graph_1, first_vertex, second_vertex, input_path_length))
print('G2')
print_paths(find_paths(graph_2, first_vertex, second_vertex, input_path_length))
