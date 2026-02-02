hexResult = []
binResult = []


def convertToHex(myString):
    hexResult.clear()
    for ch in myString:
        hexResult.append(hex(ord(ch)).replace('0x', '').upper().zfill(2))
    return hexResult


def convertToBin(myString):
    binResult.clear()
    for ch in myString:
        binResult.append(bin(ord(ch)).replace('0b', '').upper().zfill(8))
    return binResult


def convertBintoHex(inArr):
    tempStr = ''
    outArr = []
    x = 0
    for y in range(0, 8):
        tempStr = ''
        for x in range(x, x + 8):
            tempStr = tempStr + inArr[x]
            x = x + 1
        outArr.append(hex(int(tempStr, 2)).replace('0x', '').upper().zfill(2))
    return outArr


def convertBintoHex48(inArr):
    tempStr = ''
    outArr = []
    x = 0
    for y in range(0, 6):
        tempStr = ''
        for x in range(x, x + 8):
            tempStr = tempStr + inArr[x]
            x = x + 1
        outArr.append(hex(int(tempStr, 2)).replace('0x', '').upper().zfill(2))
    return outArr


def IP(binArray):
    ip_table = [58, 50, 42, 34, 26, 18, 10, 2,
                60, 52, 44, 36, 28, 20, 12, 4,
                62, 54, 46, 38, 30, 22, 14, 6,
                64, 56, 48, 40, 32, 24, 16, 8,
                57, 49, 41, 33, 25, 17, 9, 1,
                59, 51, 43, 35, 27, 19, 11, 3,
                61, 53, 45, 37, 29, 21, 13, 5,
                63, 55, 47, 39, 31, 23, 15, 7]
    outArray = list(range(64))
    for x in range(0, len(binArray)):
        outArray[x] = binArray[ip_table[x] - 1]
    tempStr = ''
    for x in range(0, len(outArray)):
        tempStr = tempStr + outArray[x]
    return tempStr


def exP(inBin, whichSide):

    #print("in exp(), inBin ="+ inBin)

    exp_table = ["2:48", "3", "4", "5:7", "6:8", "9", "10", "11:13",
                 "12:14", "15", "16", "17:19", "18:20", "21", "22", "23:25",
                 "24:26", "27", "28", "29:31", "30:32", "33", "34", "35:37",
                 "36:38", "39", "40", "41:43", "42:44", "45", "46", "47:1"]

    add = 0 if whichSide == 'Left' else 32
    output = list(range(48))
    for x in range(len(exp_table)):
        val1 = int(exp_table[x].split(":")[0])
        output[val1 - 1] = inBin[x + add]
        if len(exp_table[x].split(":")) > 1:
            val2 = int(exp_table[x].split(":")[1])
            output[val2 - 1] = inBin[x + add]
    return output


choice = input("Enter 'W' to input a word or 'H' to input a hexadecimal string: ").strip().upper()
#DF24CFD600FE4A1E
if choice == 'W':
    myString = input("Enter a word: ")
    print("Initial: ", myString)
    print("Hex: ", *convertToHex(myString))
    print("Binary: ", *convertToBin(myString), sep='')
elif choice == 'H':
    myHex = input("Enter a hexadecimal string: ").strip()
    if myHex == "":
        myHex = "F709C77100FE2232"
        #DF24CFD600FE4A1E = ['00', '17', 'FC', '25', '40', 'FC']
        print("myHex=",myHex)

    binResult = [bin(int(myHex[i:i + 2], 16)).replace('0b', '').zfill(8) for i in range(0, len(myHex), 2)]
    print("Binary: ", *binResult, sep='')
else:
    print("Invalid choice.")
    exit()

# Flag to control printing of the expansion binary result
print_expansion_left_bin = True

### new stuff ###

if choice == "H":
    choice2 = input("Do an immediate expansion for the Expansion Permutation?  Y/N >").strip().upper()
    if choice2 == 'Y':

        tempBinary="".join(binResult)
        tempResult = exP(tempBinary,None)
        tempHexResult = convertBintoHex48(tempResult)
        print("**** Expansion result tempHexResult=",tempHexResult)
        exit()
    else:
        print_expansion_left_bin = False
#################

tempStr = ''
for x in range(0, 8):
    for y in range(0, 8):
        tempStr = tempStr + binResult[x][y]

pArray = IP(tempStr)
pHexArray = convertBintoHex(pArray)

print("After Initial Permutation: ", *pHexArray, sep='')
print("pHexArray =",pHexArray)

expandedBinLeft = exP(pArray, 'Left')

if print_expansion_left_bin:
    print("Expansion", expandedBinLeft)

tempStr = ''
for x in range(0, 48):
    tempStr = tempStr + expandedBinLeft[x]

exapandedLeftHex = convertBintoHex48(tempStr)
print("Left: ", *exapandedLeftHex, sep='')

expandedBinRight = exP(pArray, 'Right')
tempStr = ''
for x in range(0, 48):
    tempStr = tempStr + expandedBinRight[x]

exapandedRightHex = convertBintoHex48(tempStr)
print("Right: ", *exapandedRightHex, sep='')