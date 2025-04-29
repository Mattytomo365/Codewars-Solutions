import re

class Converter():
    @staticmethod
    def to_ascii(h):

        return (''.join([chr(int(h[i:i + 2], 16)) for i in range(0, len(h), 2)]))


    @staticmethod
    def to_hex(s):
        words = re.split(r"(\s+)", s)
        letters = []

        for word in words:
            for char in word:
                letters.append(char)

        values = []

        for letter in letters:
            values.append(ord(letter))

        hex_values = []

        for value in values:
            hex_values.append(hex(value).lstrip('0x'))

        hex_value = ''.join(hex_values)

        return hex_value

s = "Look mom, no hands"
h = "4c6f6f6b206d6f6d2c206e6f2068616e6473"
print(Converter.to_hex(s))
print(Converter.to_ascii(h))

