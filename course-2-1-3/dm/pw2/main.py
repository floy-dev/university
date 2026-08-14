import heapq


def deikstra(matrix, start_vertex, end_vertex):
    matrix_len = len(matrix)

    start_vertex -= 1
    end_vertex -= 1

    distances = [float('inf')] * matrix_len
    distances[start_vertex] = 0

    visited = [False] * matrix_len
    shortest_path = []

    priority_queue = [(0, start_vertex)]

    while priority_queue:
        _, current_vertex = heapq.heappop(priority_queue)

        if current_vertex == end_vertex:
            break

        if visited[current_vertex]:
            continue

        visited[current_vertex] = True

        for neighbor in range(matrix_len):
            if matrix[current_vertex][neighbor] != 0 and not visited[neighbor]:
                new_distance = distances[current_vertex] + matrix[current_vertex][neighbor]
                if new_distance < distances[neighbor]:
                    distances[neighbor] = new_distance
                    heapq.heappush(priority_queue, (new_distance, neighbor))

    vertex = end_vertex
    while vertex != start_vertex:
        shortest_path.append(vertex + 1)
        for neighbor in range(matrix_len):
            if matrix[neighbor][vertex] != 0 and distances[vertex] == distances[neighbor] + matrix[neighbor][vertex]:
                vertex = neighbor
                break

    shortest_path.append(start_vertex + 1)
    shortest_path.reverse()

    return shortest_path


graph_1 = [
    [0, 1, 0, 0, 0, 0, 1],
    [1, 0, 0, 0, 0, 1, 1],
    [0, 0, 0, 1, 1, 1, 0],
    [0, 0, 1, 0, 1, 0, 0],
    [0, 0, 1, 1, 0, 1, 0],
    [0, 1, 1, 0, 1, 0, 1],
    [1, 1, 0, 0, 0, 1, 0]
]

start_vertex = 1
end_vertex = int(input("Введите конечную вершину (от 1 до {}): ".format(len(graph_1))))
shortest_path = deikstra(graph_1, start_vertex, end_vertex)
print("Минимальный путь от вершины {} до вершины {}: {}".format(start_vertex, end_vertex, shortest_path))
