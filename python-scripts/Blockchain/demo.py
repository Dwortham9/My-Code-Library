import hashlib
#create 5 hashes
hash1 = hashlib.sha256(b"This is my first hash")
hash2 = hashlib.sha256(b"This is my second hash")
hash3 = hashlib.sha256(b"This is my third hash")
hash4 = hashlib.sha256(b"This is my forth hash")
hash5 = hashlib.sha256(b"This is my fifth hash")
#print the 5 hashes in upper case
print("hash1: ",hash1.hexdigest().upper())
print("hash2: ",hash2.hexdigest().upper())
print("hash3: ",hash3.hexdigest().upper())
print("hash4: ",hash4.hexdigest().upper())
print("hash5: ",hash5.hexdigest().upper())
#create hash of empty/initial 'chain'
chain = hashlib.sha256()
#print hash of initial chain
print("\nInitial Chain:\n",chain.hexdigest().upper())


#update chain to include hash of
#hash of prior and new hash combined
#print results 5 times
print("\nUpdated Chain\nAdding:\t",hash5.hexdigest().upper())
chain.update(hash5.digest())
print("New:\t",chain.hexdigest().upper())
print("\nUpdated Chain\nAdding:\t",hash2.hexdigest().upper())
chain.update(hash2.digest())
print("New:\t",chain.hexdigest().upper())
print("\nUpdated Chain\nAdding:\t",hash1.hexdigest().upper())
chain.update(hash1.digest())
print("New:\t",chain.hexdigest().upper())
print("\nUpdated Chain\nAdding:\t",hash3.hexdigest().upper())
chain.update(hash3.digest())
print("New:\t",chain.hexdigest().upper())
print("\nUpdated Chain\nAdding:\t",hash4.hexdigest().upper())
chain.update(hash4.digest())
print("New:\t",chain.hexdigest().upper())
#print final chain value
print("\nFinal Chain:\n", chain.hexdigest().upper())
