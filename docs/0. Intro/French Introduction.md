# Bienvenue à Lesko

[Arabe](https://github.com/Mohamed-Akram-Hl/docs/blob/main/0.%20Intro/Arabic%20Introduction.md) |
[Anglais](https://github.com/Mohamed-Akram-Hl/docs/blob/main/0.%20Intro/English%20Introduction.md)

<h1 align="center">  
  <img src="https://github.com/Mohamed-Akram-Hl/docs/blob/main/assets/Logo.png?raw=true" width="200px"/>  
</h1>  

### Qu'est-ce que Lesko ?  

Lesko est un langage de programmation compilé conçu pour être similaire au langage algorithmique.  

Un langage de programmation compilé est un type de langage où le code source est traduit en code machine (code binaire) avant d’être exécuté par l’ordinateur. En d’autres termes, le code est compilé dans une forme compréhensible directement par l’ordinateur.  

Par exemple, lorsque vous écrivez du code en C, C++ ou Fortran, il doit être compilé en code machine avant de pouvoir être exécuté. Le compilateur lit le code, vérifie les erreurs et le traduit dans une forme compréhensible par l’ordinateur. Ce code compilé est ensuite sauvegardé sous la forme d’un fichier exécutable indépendant.  

Dans ce cas, j’ai utilisé C# pour développer le compilateur. Le code source sera traduit en code C# natif et, s’il n’y a pas d’erreurs, il sera exécuté.  

### L'objectif de Lesko  

Au lycée, nous apprenons les algorithmes, mais il n’existe aucun moyen de les exécuter sur un ordinateur. Pour résoudre ce problème, j’ai créé un nouveau langage qui ressemble au langage algorithmique et développé une extension pour Visual Studio Code. Cela nous permet d’écrire et d’exécuter du code directement dans Visual Studio Code sans avoir besoin de traduire les algorithmes en Python.  

Il peut également aider les débutants à apprendre les bases de la programmation.  

Nous pouvons résoudre des problèmes simples comme calculer la somme de deux nombres donnés :  

```
ecrire("entrer a : ")  
var a = entier(lire())  
ecrire("entrer b : ")  
var b = entier(lire())  
var c = a + b  
ecrire("a + b = " + chaine(c))  
```  

* Le résultat sera :  

```
entrer a :   
10  
entrer b :  
20  
a + b = 30  
```  

> Image depuis l'éditeur de code  

![sum](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20195930.png)  

Ou nous pouvons aller plus loin pour calculer les solutions d’une équation du second degré :  

```
ecrire("spécifier a :")  
var a = reel(lire())  
ecrire("spécifier b :")  
var b = reel(lire())  
ecrire("spécifier c :")  
var c = reel(lire())  
var delta = b ** 2 - 4 * a * c  
si a == 0 {  
    ecrire("Cette équation n'est pas du second degré.")  
}  
sinon si delta > 0 {  
    var x = (-b - racine(delta)) / (2 * a)  
    var y = (-b + racine(delta)) / (2 * a)  
    ecrire("Les solutions sont :")  
    ecrire(x)  
    ecrire(y)  
}  
sinon si delta == 0 {  
    var x = -b / (2 * a)  
    ecrire("La solution est :")  
    ecrire(x)  
}  
sinon {  
    ecrire("L'équation n'a pas de solutions.")  
}  
```  

* Le résultat sera :  

```
spécifier a :  
1  
spécifier b :  
-3  
spécifier c :  
2  
Les solutions sont :  
1  
2  
```  

> Image depuis l'éditeur de code  

![quad](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20200951.png)  

> Pour apprendre comment créer un fichier Lesko et exécuter votre premier code, cliquez simplement sur le bouton suivant.  

[Suivant ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/1.%20Installation%20and%20Setup/Installation%20and%20Setup.md)
