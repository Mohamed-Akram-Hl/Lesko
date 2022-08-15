# Arreter and Continuer 

### Lesko "Arreter"

When Lesko reaches a `arreter` keyword, it jumps out of the loop.

This will stop the execution of more code and case testing inside the block.

* Example 

This example jumps out of the loop when i is equal to 4:

```
pour i = 0 jusqua 10 
{
  si i == 4
  {
    arreter
  }
  ecrire(i)
}
// The output will be the numbers from 0 to 3
```

You can also use `arreter` in `tantque` loops:

```
var i = 0
tantque i < 10 
{
  ecrire(i)
  i = i + 1
  si i == 4
  {
    arreter
  }
}
```

### Lesko Continuer

The `continuer` statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

* Example

This example skips the value of 4:

```
pour i = 0 jusqua 10
{
  si i == 4
  {
    continuer
  }
  ecrire(i)
}
// 4 will not be printed in the console
```

And for sure you can use `continuer` in `tantque` loops:

```
var i = 0
tantque i < 10 
{
  si i == 4
  {
    i = i + 1
    continuer
  }
  ecrire(i)
  i = i + 1
}
```

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.1.%20Loops/loops.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.3.%20Functions/Functions.md)
