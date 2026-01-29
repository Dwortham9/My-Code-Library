print("Index of Coincidence (IOC)")
print(" ")
print("IOC formula:")
print("#a’s(#a’s-1)+#b’s(#b’s-1)+. . . \n"
        "--------------------------------\n"
        "TotalLetters(TotalLetters-1)")
print(" ")
text = input("Enter text: ")
print(" ")
text = text.upper()

lc = [0] * 26
for x in range(26):
    lc[x] = text.count(chr(x + 65))
    print(f"{chr(x + 65)}'s: {lc[x]}")

total_letters = sum(lc)
print("Total Letters: ", total_letters)

if total_letters <= 1:
    print("Text is too short to calculate IOC.")

numerator = sum(count * (count - 1) for count in lc)
denominator = total_letters * (total_letters - 1)

if denominator == 0:
    print("Unable to calculate IOC due to insufficient data.")

ioc = numerator / denominator
print("IOC: ",ioc)
