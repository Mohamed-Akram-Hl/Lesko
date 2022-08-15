# SI ... SINON

### Conditions and SI Statements

Lesko supports the usual logical conditions from mathematics:

Less than: `a < b`
 
Less than or equal to: `a <= b`

Greater than: `a > b`

Greater than or equal to: `a >= b`

Equal to: `a == b`

Not Equal to: `a != b`

You can use these conditions to perform different actions for different decisions.

Lesko has the following conditional statements:

Use `si` to specify a block of code to be executed, if a specified condition is true

Use `sinon` to specify a block of code to be executed, if the same condition is false

Use `sinon si` to specify a new condition to test, if the first condition is false

### The si Statement

Use the `si` statement to specify a block of C# code to be executed if a condition is True.

* Example

```
si 20 > 18 
{
  ecrire("20 is greater than 18")
}
```

### The sinon Statement

Use the `sinon` statement to specify a block of code to be executed if the condition is False.

```
var time = 20
si time < 18 
{
  ecrire("Good day.")
}
sinon 
{
  ecrire("Good evening.")
}
// Outputs "Good evening."
```

### The sinon si Statement

Use the `sinon si` statement to specify a new condition if the first condition is False.

* Example

```
var time = 22
si time < 10 
{
  ecrire("Good morning.")
} 
sinon si time < 20 
{
  ecrire("Good day.")
} 
sinon 
{
  ecrire("Good evening.")
}
// Outputs "Good evening."
```

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/8.%20Built%20in%20Functions/Built%20in%20Functions.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.1.%20Loops/loops.md)
