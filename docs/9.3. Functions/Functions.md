# Functions

A function is a block of code which only runs when it is called.

You can pass data, known as parameters, into a function.

A function can return data as a result.

### Creating a Function

In lesko a function is defined using the `fonction` keyword:

* Example

```
fonction test()
{
  ecrire("Hello from a function")
}
```

### Calling a Function

To call a function, use the function name followed by parenthesis:

```
fonction test()
{
  ecrire("Hello from a function")
}
test()
```

### Arguments

Information can be passed into functions as arguments.

Arguments are specified after the function name, inside the parentheses. You can add as many arguments as you want, just separate them with a comma and specify the type of each argument..

The following example has a function with one argument (fname). When the function is called, we pass along a first name, which is used inside the function to write the full name:

```
fonction name(fame : chaine)
{
  ecrire(fame + " is the best.")
}
name("Elon")
name("Bill")
name("Linus")
```

### Number of Arguments

By default, a function must be called with the correct number of arguments. Meaning that if your function expects 2 arguments, you have to call the function with 2 arguments, not more, and not less.

```
fonction salery(name : chaine, num : chaine)
{
  ecrire("The salery of " + name + " is " + num + "$.")
}
salery("Mark", "1000")
```

### Return Values

To let a function return a value, use the `retourner` statement:

```
fonction Mul(x:entier):entier
{
   retourner 5 * x
}

ecrire(Mul(10))
ecrire(Mul(2))
ecrire(Mul(3))
```

> When using retourner keyword, you must specify the type of what you're returning.

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.2.%20Arreter%20and%20Continuer/Arreter%20and%20Continuer.md)|
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.4%20Problem%20Solving/Problem%20Solving.md)
