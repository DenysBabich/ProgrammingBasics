import math
import random


class TSeries:

    def get_element(self, n):
        return 0

    def sum_element(self, n):
        return 0

    def print_series(self, n):

        i = 1
        _n = n + 1

        while i < _n:
            if i < _n - 1:
                print(f"{(int)(self.get_element(i))}, ", end='')
            else:
                print(f"{(int)(self.get_element(i))}...")
            i += 1

    def __init__(self, first_element, difference):
        self.first_element = first_element
        self.difference = difference


class GeometricProgression(TSeries):

    def get_element(self, n):
        return self.first_element * math.pow(self.difference, n - 1)

    def sum_element(self, n):
        return (self.first_element * (1 - math.pow(self.difference, n))) / (1 - self.difference)

    def __init__(self, first_element, difference):
        super().__init__(first_element, difference)


class ArithmeticProgression(TSeries):

    def get_element(self, n):
        return self.first_element + self.difference * (n - 1)

    def sum_element(self, n):
        return (2 * self.first_element + self.difference * (n - 1)) / 2 * n

    def __init__(self, first_element, difference):
        super().__init__(first_element, difference)


def find_max(series, n):
    _max = series[0].get_element(n)
    result = 0

    for i in range(1, len(series)):

        if _max < series[i].get_element(n):
            _max = series[i].get_element(n)
            result = i

    return result


def fill_progressions(length, first_element_lower = 1, first_element_upper = 50, difference_min = 2, difference_max = 10):
    series = list()

    for i in range(0, length):
        if i % 2 == 0:
            series.append(GeometricProgression(random.randint(first_element_lower, first_element_upper), random.randint(difference_min, difference_max)))
        else:
            series.append(ArithmeticProgression(random.randint(first_element_lower, first_element_upper), random.randint(difference_min, difference_max)))

    return series


def print_progressions(series, max_num):
    for i in range(0, len(series)):
        series[i].print_series(max_num)


length = int(input("Введіть кількість прогресій: "))

series = fill_progressions(length)

num_to_compare = int(input("Введіть елемент прогресії для порівняння: "))

print_progressions(series, num_to_compare)

selected_progression = find_max(series, num_to_compare)

print(f"У {selected_progression+1}-й послідовності {num_to_compare} елемент є найбільшим і дорівнює: {series[selected_progression].get_element(num_to_compare)}.")

num_sum = int(input("Введіть кількість елементів прогресії для знаходження суми: "))

print(f"Сума елементів послідовності дорівнює: {series[selected_progression].sum_element(num_sum)}")