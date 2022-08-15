# Operators

Operators are used to perform operations on variables and values.

In the example below, we use the + operator to add together two values:

* Example:

```
ecrire(10 + 5)
```

Lesko divides the operators in the following groups:

* Arithmetic operators

* Comparison operators

* Logical Operators

### Arithmetic Operators

Arithmetic operators are used with numeric values to perform common mathematical operations:

Operator      | Name           | Example     | Output
--------------|----------------|-------------|-------
 `+`          | Addition       | 3 + 4       | 7
 `-`          | Subtraction    | 5 - 1       | 4
 `*`          | Multiplication | 5 * 3       | 15
 `/`          | Division       | 10 / 2      | 5
 `mod` or `%` | Modulus        | 10 mod 3    | 1
 `**`         | Exponentiation | 3 ** 2      | 9
 `div`        | Floor division | 10 div 3    | 3
 `()`         | parenthesis    | 3 * (4 + 1) | 15

* Comparison Operators

Comparison operators are used to compare two values:

Operator      | Name                     | Example  | Output
--------------|--------------------------|----------|-------
 `==`         | Equal                    | 3 == 2   | False
 `!=`         | Not Equal                | 3 != 2   | True
 `>`          | Greater than             | 100 > 30 | True
 `<`          | Less than                | 12 < 22  | True
 `>=`         | Greater than or equal to | 10 >= 10 | True
 `<=`         | Less than or equal to	   | 10 <= 6  | False
 
 * Logical Operators

Logical operators are used to combine conditional statements:

Operator                   | Description                                             | Example         | Output
---------------------------|---------------------------------------------------------|-----------------|-------
`et` or `&&`               | Returns True if both statements are true                | 1 < 5 et 1 < 10 | True
`ou` or `PipePipe symbole` | Returns True if one of the statements is true           | 6 < 5 ou 2 < 4	 | True
`non` or `!`               | Reverse the result, returns False if the result is true | non( 3 < 5 )    | False

> PipePipe symbole is `||` in keyboard. Just type `|` two times.

* Bitwise Operators

Bitwise operators are used to compare (binary) numbers:

Operator       | Name | Description                                     | Example              | Output
---------------|------|-------------------------------------------------|----------------------|-------
`~`            | NOT  | Inverts all the bits                            | ~12                  | -13
`&`            | AND  | Sets each bit to 1 if both bits are 1           | 12 & 13	             | 12
`Pipe symbole` | OR   | Sets each bit to 1 if one of two bits is 1      | 12 `Pipe symbole` 13 | 13
`^`            | XOR  | Sets each bit to 1 if only one of two bits is 1 | 12 ^ 13              | 1

> PiPe symbole is `|` in keyboard.

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/6.%20Booleans/Booleans.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/8.%20Built%20in%20Functions/Built%20in%20Functions.md)
