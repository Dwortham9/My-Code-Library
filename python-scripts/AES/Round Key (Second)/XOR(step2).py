def xor(dataType, *args):
    if dataType == 'hex':
        # Split each input into list of hex values
        hex_lists = [arg.split(',') for arg in args]
        length = len(hex_lists[0])
        if not all(len(lst) == length for lst in hex_lists):
            raise ValueError("All hex inputs must have the same number of elements.")
        
        result = []
        for i in range(length):
            xor_val = 0
            for lst in hex_lists:
                xor_val ^= int(lst[i], 16)
            result.append(hex(xor_val)[2:].upper().zfill(2))
        return ','.join(result)

    elif dataType == 'bin':
        # Split each input into list of binary values
        bin_lists = [arg.split(',') for arg in args]
        length = len(bin_lists[0])
        if not all(len(lst) == length for lst in bin_lists):
            raise ValueError("All binary inputs must have the same number of elements.")
        
        result = []
        for i in range(length):
            xor_val = 0
            for lst in bin_lists:
                xor_val ^= int(lst[i], 2)
            result.append(bin(xor_val)[2:].zfill(8))
        return ','.join(result)

    else:
        raise ValueError("Unsupported dataType. Use 'hex' or 'bin'.")
    
val1 = "B1,DD,48,7A"
val2 = "22,30,8B,83"

result = xor('hex', val1, val2)
print("Hex XOR:", result)

# Convert each result hex to binary
binary_results = ','.join([bin(int(h, 16))[2:].zfill(8) for h in result.split(',')])
print("Binary of hex XOR:", binary_results)


def xor(dataType, *args):
    outVal = []
    if dataType == 'hex':
        for x in range(0, len(args[0]), 2):
            outVal.append(hex(int(args[0][x:x+2], 16) ^ int(args[1][x:x+2], 16)).replace('0x','').upper().zfill(2))
        return ''.join(outVal)
    if dataType == 'bin':
        # For binary, we expect full 8-bit values, so no need to chunk
        xor_result = bin(int(args[0], 2) ^ int(args[1], 2))[2:].zfill(8)
        return xor_result