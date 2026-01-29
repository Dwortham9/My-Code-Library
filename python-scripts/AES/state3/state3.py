def shift_left(lst, n):
    n = n % len(lst)
    return lst[n:] + lst[:n]

# Example usage:
my_list = ['C6','C6','3C','7B']
shifted = shift_left(my_list, 3)
print(shifted)