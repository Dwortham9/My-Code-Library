print("RSA Encryption/Decryption")

choice = input("Do you want to enter your own values (manual) or calculate d automatically? ((m)anual/(a)uto): ").lower()
if choice == "m":
    p = int(input('p: '))
    q = int(input('q: '))
    e = int(input('e: '))
    d = int(input('d: '))

    n = p * q
    tn = (p - 1) * (q - 1)
    choice = input("Do you want to encrypt (cipher) or decrypt (plaintext)? (c/p): ").lower()
    if choice == 'c':
        P = int(input("Enter Plaintext (P): "))
        Cipher = pow(P, e, n)
        print("Cipher (C):", Cipher)

    elif choice == 'p':
        C = int(input("Enter Ciphertext (C): "))
        Plaintext = pow(C, d, n)
        print("Plaintext (P):", Plaintext)

    else:
        print("Invalid choice. Please enter 'c' or 'p'.")

elif choice == "a":
    def comp_for_d(tn, e):
        nlist = []
        for x in range(1, 100000000, tn):
            nlist.append(x)
        count = 0
        for x in range(0, 100000000, e):
            if x in nlist:
                return count
            count += 1

    p = int(input("Enter value for p: "))
    q = int(input("Enter value for q: "))
    e = int(input("Enter value for e: "))

    n = p*q
    tn = (p-1)*(q-1)
    d = comp_for_d(tn, e)

    ask = input("Is there any P's (plaintext) or C's (cipher)? (y/n): ")
    if ask.lower() == 'y':
        what = input("Finding P's (plaintext) or C's (cipher)? (p/c): ")
        if what.lower() == 'p':
            C = int(input("Enter value for C: "))
            P = pow(C, d, n)
            print("Plaintext (P):", P)
        elif what.lower() == 'c':
            P = int(input("Enter value for P: "))
            C = pow(P, e, n)
            print("Cipher (C):", C)
        else:
            print("Invalid choice.")
    elif ask.lower() == 'n':
        print("No encryption/decryption requested.")

    print("\n--- RSA Parameters ---")
    print("p:", p)
    print("q:", q)
    print("e:", e)
    print("n (modulus):", n)
    print("tn (totient):", tn)
    print("d (private key):", d)