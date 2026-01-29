import hashlib
import itertools
import math

hash1 = hashlib.sha256(b"This is my first hash")
hash2 = hashlib.sha256(b"This is my second hash")
hash3 = hashlib.sha256(b"This is my third hash")
hash4 = hashlib.sha256(b"This is my forth hash")
hash5 = hashlib.sha256(b"This is my fifth hash")

print("hash1: ",hash1.hexdigest().upper())
print("hash2: ",hash2.hexdigest().upper())
print("hash3: ",hash3.hexdigest().upper())
print("hash4: ",hash4.hexdigest().upper())
print("hash5: ",hash5.hexdigest().upper())

hashes = [hash1, hash2, hash3, hash4, hash5]
numHashes = len(hashes)

print("Permutation of Hashes - Order Matters")
print(f"Available Hashes: {numHashes} (1 to {numHashes})")

for c in range(1, numHashes + 1):
    perm_count = math.perm(numHashes, c)
    print(f"Using {c} hashes produces {perm_count:,} permutations")

if input("\nShow hash permutations and chains? (y/n): ").lower() == 'y':
    c = int(input(f"How many hashes to use (1-{numHashes}): "))
    
    for i, perm in enumerate(itertools.permutations(hashes, c)):
        chain = hashlib.sha256()
        
        hash_order = [hashes.index(h) + 1 for h in perm]
        print(f"\nPermutation {i+1}: Hashes {hash_order}")
        
        for j, h in enumerate(perm, 1):
            chain.update(h.digest())
            print(f"Step {j}: {chain.hexdigest().upper()}")
        
        print(f"Final Chain Digest: {chain.hexdigest().upper()}")