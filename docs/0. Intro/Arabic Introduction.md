# مرحبا بك في Lesko

[English](https://github.com/Mohamed-Akram-Hl/docs/blob/main/0.%20Intro/English%20Introduction.md) |
[Français](https://github.com/Mohamed-Akram-Hl/docs/blob/main/0.%20Intro/French%20Introduction.md)
<h1 align="center">
  <img src="https://github.com/Mohamed-Akram-Hl/docs/blob/main/assets/Logo.png?raw=true" width="200px"/>
</h1>


### ماهي Lesko ؟

 ليسكو (Lesko) هي لغة برمجة تعمل بواسطة مترجم مصممة لتكون أقرب ما يمكن إلى اللغة الخوارزمية.

علما و ان لغات البرمجة التي تعمل بواسطة مترجم هي نوع من لغات البرمجة حيث يتم ترجمة كود المصدري إلى كود آلة (كود ثنائي) قبل أن يتم تنفيذه بواسطة الكمبيوتر. بمعنى آخر ، تتم ترجمة الكود بشكل يمكن للكمبيوتر فهمه وتنفيذه مباشرة.

على سبيل المثال ، عندما تكتب تعليمة برمجية بلغة C أو ++ C أو Fortran ، يجب ترجمتها إلى كود الآلة قبل تنفيذها. يقرأ المترجم الكود ، ويتحقق من الأخطاء ويترجمها إلى نموذج يمكن للكمبيوتر فهمه. ثم يتم حفظ هذا الكود المترجم كملف منفصل قابل للتنفيذ ، والذي يمكن تشغيله بشكل مستقل.

في هذه الحالة ، استخدمت #C لتطوير المترجم. حتى يقوم بترجمة الكود المصدري إلى كود #C ، وإذا لم تكن هناك أخطاء ، فسيتم تنفيذه.

### الغرض من Lesko

في المعاهد الثانوية، نقوم بدراسة الخورزميات لكن لا توجد طريقة لتشغيلها على الحواسيب. لمعالجة هذه المشكلة ، قمت بإنشاء لغة جديدة تشبه اللغة الخوارزمية 
و طورت ملحق Visual Studio Code. يتيح لنا ذلك كتابة التعليمات البرمجية وتنفيذها مباشرةً داخل Visual Studio Code دون الحاجة إلى ترجمة الخوارزميات إلى Python


كما يمكن للمبتدئين تعلم أساسيات البرمجة من خلالها

يمكننا حل بعض المسائل البسيطة مثل حساب مجموع عددين:


```
ecrire("entrer a: ")
var a = entier(lire())
ecrire("entrer b: ")
var b = entier(lire())
var c = a + b
ecrire("a + b = " + chaine(c))
```

* النتيجة ستكون على النحو التالي:

```
entrer a: 
10
entrer b:
20
a + b = 30
```

> صورة من محرر الكود (Viusal Studio Code)


![sum](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20195930.png)


أو يمكننا الذهاب أبعد من ذلك لحل معادلات من الدرجة الثانية:
 
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

* النتيجة ستكون على النحو التالي:

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

> صورة من محرر الكود (Viusal Studio Code)


![quad](https://raw.githubusercontent.com/Mohamed-Akram-Hl/docs/main/assets/Screenshot%202023-02-10%20200951.png)


[التالي ->](https://github.com/Mohamed-Akram-Hl/docs/blob/main/1.%20Installation%20and%20Setup/Installation%20and%20Setup.md)
