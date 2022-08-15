# Booleans

Booleans represent one of two values: `vrai` or `faux`.

### Boolean Values

In programming you often need to know if an expression is True or False.

You can evaluate any expression in Lesko, and get one of two answers, True or False.

When you compare two values, the expression is evaluated and Lesko returns the Boolean answer:

* Example

```
ecrire(10 > 9)       // True
ecrire(vrai == faux) // False
ecrire(vrai == vrai) // True
ecrire(10 == 9)      // False
ecrire(10 < 9)       // False
```

When you run a condition in an `si` statement, Lesko returns True or False:

```
var a = 200
var b = 33

si b > a {
  ecrire("b is greater than a")}
sinon {
  ecrire("b is less than a")}
```
[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/5.%20Data%20Type/Data%20Types.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/7.%20Operators/Operators.md)
