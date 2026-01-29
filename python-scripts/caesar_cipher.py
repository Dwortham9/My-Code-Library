print("Caesar cipher")
shift = int(input("Enter the shift: "))
result = ""
shift = -shift
text = input("Enter text: ")
for char in text:
    if char.isalpha():
        start = ord('A') if char.isupper() else ord('a')
        result += chr((ord(char) - start + shift) % 26 + start)
    else:
        result += char
print(result)