import numpy as np


def count_paths(matrix, n):
    return np.linalg.matrix_power(matrix, n)


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

path_length = 3
first_vertex = 1
second_vertex = 2

print(f'G1, количество маршрутов с длиной {path_length} из вершины {first_vertex} в вершину {second_vertex}: ')
print(count_paths(graph_1, path_length)[first_vertex - 1][second_vertex - 1])
print(f'G2, количество маршрутов с длиной {path_length} из вершины {first_vertex} в вершину {second_vertex}: ')
print(count_paths(graph_2, path_length)[first_vertex - 1][second_vertex - 1])
