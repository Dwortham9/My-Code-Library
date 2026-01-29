word = input("Enter a word: ")
hex_values = [format(ord(c), '02X') for c in word]

num_cols = 4
num_rows = (len(hex_values) + num_cols - 1) // num_cols


while len(hex_values) < num_rows * num_cols:
    hex_values.append('  ')

for row in range(num_rows):
    for col in range(num_cols):
        print(hex_values[col * num_rows + row].ljust(4), end=' ')
    print()


#answer is each column