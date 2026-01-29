print("Inverse of W^-1")
print("M1 = W^(N-2)%N\n"
        "M2 = Comparison\n"
        "M3 = W^W%N")
def m2(W,N):
    nlist=[]
    for x in range(1, 100000000,N):
        nlist.append(x)
    c=0
    for x in range(0,100000000,W):
        if x in nlist:
            return c
        c+=1
W = int(input("Enter value for W: "))
N = int(input("Enter value for N: "))

M1 = print("M1: ", W**(N-2)%N)
M2 = print("M2: ", m2(W,N))
M3 = print("M3: ", W**W%N)