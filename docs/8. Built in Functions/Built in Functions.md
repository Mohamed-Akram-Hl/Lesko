# Built in Functions

### ecrire() Function

The `ecrire()` function prints the specified message to the screen, or other standard output device.

The message can be a string, or any other object, the object will be converted into a string before written to the screen.

* Example

Write a message onto the screen:

```
ecrire("Hello World")
```

### lire() Function

The `lire()` function allows user input.

* Example

Ask for the user's name and write it:

```
ecrire("entrer votre nom:")
var x = lire()
ecrire("bonjour, " + x)
```

### alea() Function

The `alea()` function returns an integer number between 0 and a given integer.

* Example

Return a number between 0 and 10 (10 is not included):

```
ecrire(alea(10))
```

### absolu() Function

The `absolu()` function returns the absolute value of the specified number.

* Example 

Return the absolute value of a number:

```
var x = absolu(-7.25)
```

### racine() Function

The `racine()` function returns the square root of a complex number.

* Example

Find the square a number:

```
ecrire(racine(4))
```

### arrondir() Function

The `arrondir()` function returns returns the nearest integer.

* Example

Round a number:

```
var x = arrondir(2.2424)
ecrire(x)
```

### type() Function

The `type()` function returns the type of the specified object

* Example

Return the type of these objects:

```
var a = 2
var b = 4.5
var c = "bonjour"
var d = vrai
ecrire(a)
ecrire(b)
ecrire(c)
ecrire(d)
```

### long() Function

The len() function returns the number of characters in the string

* Example

return the number of the character

```
var x = "bonjour"
ecrire(x)
```

### entier() Function

The `entier()` function converts the specified value into an integer number.

* Example

Convert the number 3.5 into an integer:

```
var x = entier(3.5)
```

### reel() Function

The `reel()` function converts the specified value into an floating point number.

* Example

Convert the number 3 into a floating point number:

```
var x = reel(3)
```

### chaine() Function

The `chaine()` function converts the specified value into a string.

* Example

Convert the number 3 into an string:

```
var x = chaine(3)
```

### booleen() Function

The `booleen()` function converts "vrai" and "faux" to boolean.

* Example

Convert the number "vrai" to boolean:

```
var x = booleen("vrai")
```

[<- Previous](https://github.com/Mohamed-Akram-Hl/docs/blob/main/7.%20Operators/Operators.md) |
[Next ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/9.%20%20Si%20...%20Sinon/Si%20...%20Sinon.md)
