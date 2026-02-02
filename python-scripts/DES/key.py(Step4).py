key = b'ShipKey'

# 0 represents nullification
choicePermutation = [
    5, 24, 7, 16, 6, 10, 20, 18,
    0, 12, 3, 15, 23, 1, 9, 19,
    2, 0, 14, 22, 11, 0, 13, 4,
    0, 17, 21, 8, 47, 31, 27, 48,
    35, 41, 0, 46, 28, 0, 39, 32,
    25, 44, 0, 37, 34, 43, 29, 36,
    38, 45, 33, 26, 42, 0, 30, 40
]

binArray = []

for byte in key:
    for index in range(7, -1, -1): # MSB -> LSB
        bit = (byte >> index) & 1
        binArray.append(bit)

print(binArray)

shrunkBinArray = [None] * len(binArray)

for index, shiftValue in enumerate(choicePermutation):
    if shiftValue == 0:
        continue

    shrunkBinArray[shiftValue] = binArray[index]

shrunkBinArray = [i for i in shrunkBinArray if i != None] # remove None type

print("Binary shrunk: ",*shrunkBinArray, sep='')
#31 35 db 51 93 f8
binary_str = ''.join(str(bit) for bit in shrunkBinArray)
hex_digits = [format(int(binary_str[i:i+4], 2), 'X') for i in range(0, len(binary_str), 4)]
hex_str = ''.join(hex_digits)

# Space out every 2 characters (bytes)
spaced_hex = ' '.join([hex_str[i:i+2] for i in range(0, len(hex_str), 2)])

print("Spaced Hexadecimal:", spaced_hex)