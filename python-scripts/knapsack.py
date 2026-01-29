from itertools import combinations
def getHard():
    inList = []
    while True:
        inTemp = input("Please enter a value for the Hard knapsack (q to Quit): ")
        if inTemp.upper() == "Q" or len(inTemp) == 0:
            break
        else:
            inList.append(int(inTemp))
    print("Hard Knapsack is: ", end="")
    print(*inList, sep=", ")
    return inList

def getP():
    inList = []
    while True:
        inTemp = input("Please enter a value for the Plaintext (q to Quit): ")
        if inTemp.upper() == "Q" or len(inTemp) == 0:
            break
        else:
            inList.append(inTemp)
    print("Plaintext is: ", end="")
    print(*inList, sep=", ")
    return inList

def encrypt():
    h = getHard()
    p = getP()
    c = 0
    C = []
    for y in range(len(p)):
        for x in range(len(h)):
            c=c+h[x]*int(p[y][x])
        C.append(c)
        c=0
    print(C)

def calcHard():
    simple = getSSI()

    W = int(input("Enter value for W: "))
    N = int(input("Enter value for N: "))
    hard=[]
    for x in range(len(simple)):
        hard.append(W*simple[x]%N)
    print(hard)

def calcSSI(inSSI):
    curList=[]
    for x in range(1, len(inSSI)):
        curList.append(inSSI[x-1])
        if inSSI[x] <= sum(curList):
            return False
    return True
def checkSSI():
    inList = getSSI()
    print("\nVerifying SSI Knapsack")
    print(*inList, sep=", ")
    if calcSSI(inList) == True:
        print("")
    else:
        print("Invalid")
def getSSI():
    inList = []
    while True:
        inTemp = input("Please enter a value for the knapsack (q to Quit): ")
        if inTemp.upper() == "Q" or len(inTemp) == 0:
            break
        else:
            inList.append(int(inTemp))
    print("Simple Super Increasing Knapsack is: ", end="")
    print(*inList, sep=", ")
    return inList

def menuKnapsack():
    print("\nKnapsack Options")
    choice = int(input("1 Check Simple Super Increasing Knapsack \n"
            "2 Calculate Hard Knapsack \n"
            "3 Encrypt \n"
            "4 Decrypt \n"
            "Enter Here: "))

    if choice == 1:
        checkSSI()
        return ""
    if choice == 2:
        print("H = W * S % N")
        calcHard()
        return""
    if choice == 3:

        encrypt()
        return""
    if choice == 4:
        print("W^-1 * C % N")
        w1 = int(input("Enter value for W^-1: "))
        C = int(input("Enter value for C: "))
        N = int(input("Enter value for N: "))

        d = (w1 * C) % N

        print(d)

    def find_subset_with_binary(numbers, target):
        n = len(numbers)

        for i in range(1, n + 1):
            for subset in combinations(enumerate(numbers), i):  # Keep track of indices
                indices, subset_values = zip(*subset)  # Separate indices and values
                if sum(subset_values) == target:
                    # Create a binary list with 1s for used indices and 0s for unused
                    binary_representation = [1 if idx in indices else 0 for idx in range(n)]
                    return subset_values, binary_representation

        return None, None  # No subset found

    # Example Usage
    numbers = list(map(int, input("Enter numbers separated by spaces: ").split()))
    target = int(input("Enter target sum: "))

    result, binary = find_subset_with_binary(numbers, target)

    if result:
        print(f"Numbers that sum to {target}: {result}")
        print(f"Binary representation: {binary}")
    else:
        print("No subset found.")

menuKnapsack()
#menuKnapsack()