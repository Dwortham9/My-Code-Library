g = int(input("g: "))
p = int(input("p: "))
X = int(input("X: "))
Y = int(input("Y: "))

halfKeyX = pow(g,X,p)
halfKeyY = pow(g,Y,p)

print('half key X: ', halfKeyX)
print('half key Y: ', halfKeyY)

key1 = pow(halfKeyY,X,p)
key2 = pow(halfKeyX,Y,p)

print('Key1: ', key1)
print('Key2: ', key2)