# Problem Solving

Here are some solved Problem using Lesko.

### Reverse The Number

* Solution

```
// Debut
ecrire("Please Enter any Number:")
var number = entier(lire())
var reverse = 0
tantque number > 0{
    var reminder = number mod 10
    reverse = (reverse * 10) + reminder
    number = number div 10
}
ecrire("The reversed number is:")
ecrire(reverse)
// Fin
```

### Second Degree Equations

make a program which can solve The second degree equations.

* Solution:

```
//Debut
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
// fin
```
* Alternative Solution (using function):
```
//Debut
fonction verification(a : reel, b : reel, c : reel, delta : reel) {
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
}
ecrire("spécifier a:")
var a = reel(lire())
ecrire("spécifier b:")
var b = reel(lire())
ecrire("spécifier c:")
var c = reel(lire())
var delta = b ** 2 - 4 * a * c
verification(a, b, c, delta)
// fin
```

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.3.%20Functions/Functions.md)
