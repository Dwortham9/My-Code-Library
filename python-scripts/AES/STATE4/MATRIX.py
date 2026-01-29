import tkinter as tk
from tkinter import messagebox

# AES Galois Field Multiplication
def mul(a, b):
    p = 0
    for i in range(8):
        if b & 1:
            p ^= a
        hi_bit = a & 0x80
        a <<= 1
        if hi_bit:
            a ^= 0x1B
        a &= 0xFF
        b >>= 1
    return p

def mix_single_column(col):
    return [
        mul(0x02, col[0]) ^ mul(0x03, col[1]) ^ col[2] ^ col[3],
        col[0] ^ mul(0x02, col[1]) ^ mul(0x03, col[2]) ^ col[3],
        col[0] ^ col[1] ^ mul(0x02, col[2]) ^ mul(0x03, col[3]),
        mul(0x03, col[0]) ^ col[1] ^ col[2] ^ mul(0x02, col[3])
    ]

# GUI Code
class AESMixColumnsGUI:
    def __init__(self, root):
        self.root = root
        self.root.title("AES MixColumns")

        self.entries = []
        for i in range(4):
            row = []
            for j in range(4):
                e = tk.Entry(root, width=4, justify='center')
                e.grid(row=i, column=j, padx=5, pady=5)
                row.append(e)
            self.entries.append(row)

        self.button = tk.Button(root, text="MixColumns", command=self.mix_columns)
        self.button.grid(row=4, column=0, columnspan=4, pady=10)

        self.output_labels = [[tk.Label(root, text="", width=4) for _ in range(4)] for _ in range(4)]
        for i in range(4):
            for j in range(4):
                self.output_labels[i][j].grid(row=i+5, column=j, padx=5, pady=5)

    def mix_columns(self):
        try:
            # Read input and convert to integers
            state = []
            for col in zip(*self.entries):  # read column-wise
                state.append([int(e.get(), 16) for e in col])

            # Apply MixColumns to each column
            mixed = [mix_single_column(col) for col in state]

            # Display result
            for i in range(4):
                for j in range(4):
                    self.output_labels[i][j].config(text=f"{mixed[j][i]:02X}")
        except:
            messagebox.showerror("Input Error", "Please enter valid 2-digit hex values (e.g. 1A, FF, 09)")

# Run the GUI
root = tk.Tk()
app = AESMixColumnsGUI(root)
root.mainloop()