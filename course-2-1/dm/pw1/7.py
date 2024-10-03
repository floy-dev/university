def find_maximal_paths(graph, start_vertex):
    def depth_first_search(current_path, visited):
        current_vertex = current_path[-1]
        neighbors = graph[current_vertex]
        no_extension = True

        for vertex, is_connected in enumerate(neighbors):
            if is_connected and vertex not in visited:
                no_extension = False
                visited.add(vertex)
                depth_first_search(current_path + [vertex], visited)
                visited.remove(vertex)

        if no_extension:
            maximal_paths.append(current_path)

    start_vertex -= 1
    visited = {start_vertex}

    maximal_paths = []
    depth_first_search([start_vertex], visited)
    return maximal_paths


def print_paths(paths):
    paths = [[vertex + 1 for vertex in path] for path in paths]
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


input_start_vertex = 1

print('G1')
print_paths(find_maximal_paths(graph_1, input_start_vertex))
print('G2')
print_paths(find_maximal_paths(graph_2, input_start_vertex))
