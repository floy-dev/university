import heapq


def huffman(frequencies):
    heap = []
    for sym, freq in frequencies:
        heap.append((freq, [(sym, "")]))
    heapq.heapify(heap)

    while len(heap) > 1:
        low_freq, low_node = heapq.heappop(heap)
        high_freq, high_node = heapq.heappop(heap)

        for i in range(len(low_node)):
            pair_symbol, pair_code = low_node[i]
            low_node[i] = (pair_symbol, pair_code + '0')

        for i in range(len(high_node)):
            pair_symbol, pair_code = high_node[i]
            high_node[i] = (pair_symbol, pair_code + '1')

        merged_node = low_node + high_node
        heapq.heappush(heap, (low_freq + high_freq, merged_node))

    huffman_codes = {}
    for pair in heapq.heappop(heap)[1]:
        symbol, code = pair
        huffman_codes[symbol] = code

    return huffman_codes


def get_frequency_list(text):
    frequency_dict = {}
    for char in text:
        if char in frequency_dict:
            frequency_dict[char] += 1
        else:
            frequency_dict[char] = 1

    return list(frequency_dict.items())


def print_huffman_dictionary(dictionary):
    for item in dictionary:
        print(item + ': ' + dictionary[item])


text = "Дискретная математика"

frequency_list = get_frequency_list(text)
print_huffman_dictionary(huffman(frequency_list))
