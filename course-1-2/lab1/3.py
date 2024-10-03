import math

import matplotlib.pyplot as plt
import numpy

x = [-math.inf, -11 / 2, -2, 1005]
y = [1, 1, 1, 1]

fig, ax = plt.subplots()
ax.set_title('Разность')
plt.plot((0, 0), (1, 2), 'white')

min_value = 0
max_value = 0

for key, x_value in enumerate(x):

    if x_value == -math.inf:
        start_x = x[key + 1] - 2
        end_x = x[key + 1]
        min_value = start_x
    elif x_value == math.inf:
        start_x = x[key - 1]
        end_x = x[key - 1] + 2
        max_value = end_x
    else:
        if x_value == 1005 or x_value == -11 / 2:
            continue

        start_x = x_value
        end_x = x[key + 1] + 2

    for i in numpy.arange(start_x, end_x, 1):
        plt.plot((i, i), (1.05, 1.0), 'C0', linestyle="--", markersize=0)

plt.plot(x, y,
         color='white',
         marker='o',
         markersize=7,
         markeredgewidth=1.5,
         markeredgecolor='C0',
         zorder=2
         )
plt.plot((min_value, max_value), (1, 1), 'C0')

plt.show()
