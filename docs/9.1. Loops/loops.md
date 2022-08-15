# Loops

Loops can execute a block of code as long as a specified condition is reached.

Loops are handy because they save time, reduce errors, and they make code more readable.

## Lesko Tantque Loop

The `tantque` loop loops through a block of code as long as a specified condition is True:

* Example

In the example below, the code in the loop will run, over and over again, as long as a variable (i) is less than 5:

```
var i = 0
tantque i < 5 
{
  ecrire(i)
  i = i + 1
}
```

### The Faire/Tantque Loop

The `faire`/`tantque` loop is a variant of the `tantque` loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

* Example

```
var i = 5
faire
{
  ecrire("hi")
}
tantque i == 6
// The output will be "hi"
```

## Lesko Pour Loop

When you know exactly how many times you want to loop through a block of code, use the `pour` loop instead of a `tantque` loop

It start by a specified number, and increments by 1, and ends at a specified number using `jusqua` statement.
 
* Example

The example below will write the numbers 0 to 4:

```
pour i = 0 jusqua 4
{
  ecrire(i)
}
```


[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.%20%20Si%20...%20Sinon/Si%20...%20Sinon.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.2.%20Arreter%20and%20Continuer/Arreter%20and%20Continuer.md)
