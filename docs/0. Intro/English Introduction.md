# Welcome to Lesko


[Arabic](https://github.com/Mohamed-Akram-Hl/Lesko/blob/master/docs/0.%20Intro/Arabic%20Introduction.md) |
[French](https://github.com/Mohamed-Akram-Hl/docs/blob/main/0.%20Intro/French%20Introduction.md)


<h1 align="center">
  <img src="https://github.com/Mohamed-Akram-Hl/docs/blob/main/assets/Logo.png?raw=true" width="200px"/>
</h1>

### What's Lesko?


Lesko is a compiled programming language designed to be similar to the algorithmic language.

A compiled programming language is a type of programming language where the source code is translated into machine code (binary code) before being executed by the computer. In other words, the code is compiled into a form that the computer can understand and execute directly.


For example, when you write code in C, C++ or Fortran, it needs to be compiled into machine code before it can be executed. The compiler reads the code, checks for errors and translates it into a form that the computer can understand. This compiled code is then saved as a separate executable file, which can be run independently.

In this instance, I utilized C# to develop the compiler. The source code will be translated into native C# code, and if there are no errors, it will be executed.

### The Purpose of Lesko

At high school, we learn algorithms, but there is no way to run it on computers. To address this issue, I created a new language that closely resembles algorithmic language and developed a Visual Studio Code extension. This allows us to write and execute code directly within Visual Studio Code without the need to translate the algorithms into Python

It can also help beginners to learn the basics of programming.


We can solve some simple problems like calculating the sum of two given numbers:


```
ecrire("entrer a: ")
var a = entier(lire())
ecrire("entrer b: ")
var b = entier(lire())
var c = a + b
ecrire("a + b = " + chaine(c))
```

* The result will be:

```
entrer a: 
10
entrer b:
20
a + b = 30
```

> Image from the code editor

![sum](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20195930.png)

Or we can go even further to calculate the solutions of a quadratic equation:

```
ecrire("spécifier a:")
var a = reel(lire())
ecrire("spécifier b:")
var b = reel(lire())
ecrire("spécifier c:")
var c = reel(lire())
var delta = b ** 2 - 4 * a * c
si a == 0 {
    ecrire("Cette equation n'est pas de second dégré.")
}
sinon si delta > 0 {
    var x = (-b - racine(delta)) / (2 * a)
    var y = (-b + racine(delta)) / (2 * a)
    ecrire("Les solutions sont:")
    ecrire(x)
    ecrire(y)
}
sinon si delta == 0 {
    var x = -b / (2 * a)
    ecrire("La solution est:")
    ecrire(x)
}
sinon {
    ecrire("L'equation n'a pas de solutions.")
}
```

* The result will be:

```
spécifier a:
1
spécifier b:
-3
spécifier c:
2
Les solutions sont:
1
2
```

> Image from the code editor


![quad](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20200951.png)

> To learn how to create a lesko file and run your first code just hit the next button.

[Next ->](https://github.com/Mohamed-Akram-Hl/Lesko/blob/master/docs/1.%20Installation%20and%20Setup/Installation%20and%20Setup.md)
