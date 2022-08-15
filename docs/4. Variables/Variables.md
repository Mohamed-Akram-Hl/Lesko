# Lesko Variables

### Variables

Variables are containers for storing data values.

### Creating Variables

Variables are declared using `var` or `let`.

* Example

```
var x = 5
var y = "bonjour"
ecrire(x)
ecrire(y)
```

Variables do not need to be declared with any particular type, and can even change type after they have been set.

* Example

```
var x = 4       // x is of type int
var x = "bonjour" // x is now of type str
ecrire(x)
```
> Comments can be used to explain Lesko code Just by typing `//` then write the comment you want.

> Comments can not be  executed when testing code.

You can also declare a variable with a particular type:

* Example

```
var x : entier = 4 // x is of type int
ecrire(x)
```

### Casting

If you want to specify the data type of a variable, this can be done with casting.

* Example

```
var x = chaine(3)    // x will be "3"
var y = entier(3)    // y will be 3
var z = reel(3)  // z will be 3.0
```

### Get the Type

You can get the data type of a variable with the type() function.

* Example

```
var x = 5
var y = "John"
ecrire(type(x))
ecrire(type(y))
```

### Variable Names

A variable can have a short name (like x and y) or a more descriptive name (age, name). Rules for Lesko variables:

* A variable name can only contain letters (A-z).

* Variable names are case-sensitive (age, Age and AGE are three different variables)

### Output Variables

The Lesko ecrire() function is often used to output variables:

* Example

```
var x = "bienvenue au Lesko"
ecrire(x)
```

You can use the `+` operator to output multiple variables:

* Example

```
var x = "bienvenue "
var y = "au "
var z = "Lesko"
ecrire(x + y + z)
```
> In the ecrire() function, when you try to combine a string and a number with the + operator, Lesko will give you an error

For numbers, the + character works as a mathematical operator:

* Example

```
var x = 5
var y = 10
ecrire(x + y)
```

> Hit the `Next ->` button to learn more about lesko or Hit the `<- Previous` button to review the last document.

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/3.%20Strings/Strings.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/5.%20Data%20Type/Data%20Types.md)
