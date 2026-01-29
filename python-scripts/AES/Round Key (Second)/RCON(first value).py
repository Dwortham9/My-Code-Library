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


# RCON
# 00000001 = 01 first
# 00000000 = 00 second, third, fourth 

val1 = '00000100'
val2 = '00000001'

binary_xor = xor('bin', val1, val2)
print("Binary XOR:", binary_xor)
hex_result = hex(int(binary_xor, 2))[2:].upper().zfill(2)
print("Hex of binary XOR:", hex_result)