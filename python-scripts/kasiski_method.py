print("Kasiski Method")
def startDiff(inStarts):
    diffs = []
    for x in range(len(inStarts) - 1):
        diffs.append(inStarts[x + 1] - inStarts[x])
    return diffs

def findFactors(x):
    factors = []
    for y in range(2, x + 1):
        if x % y == 0:
            factors.append(y)
    return factors

def printFactors(inDiffs):
    factored = []
    for x in range(len(inDiffs)):
        factored.append(findFactors(inDiffs[x]))
    common = set(factored[0])
    for x in range(1, len(factored)):
        common = set(common).intersection(set(factored[x]))
        commonList = list(common)
        commonList.sort()
        return commonList
    
str_to_decode = input("Enter text: ")
length = int(input("Enter in the length of text: "))

dupStrings = []
for x in range(len(str_to_decode)):
    dupStrings.append(str_to_decode[x:x + length])
pos = []
startPos = 0
unique = set(dupStrings)
for words in unique:
    if dupStrings.count(words) > 2:
        print("Frequency of", words, "is: ", dupStrings.count(words))
        for x in range(dupStrings.count(words)):
            if str_to_decode.find(words, startPos + 1) > 0:
                pos.append(str_to_decode.find(words, startPos + 1) + 1)
                startPos = str_to_decode.find(words, startPos + 1)
print("Starting Positions: ", end="")
print(*pos, sep=", ")

diffs = startDiff(pos)
print("Differences:", diffs)
print("Common Factors", printFactors(diffs))
