# Тема: Програмування базових алгоритмів обробки масивів
### Варіант: 16

1. Розробити алгоритми і написати програми мовою Java із застосуванням операторів циклів for, while, do while для розв’язання завдань,
поданих в додатках 1, 2 відповідно до індивідуального варіанта. Варіант обрати за списком групи.
2. Розробити програмний проект в середовищі Intellij IDEA для реалізації написаних програм. Перевірити результати обчислень альтернативними
розрахунками (наприклад, Excel, калькулятор, тощо). 
3. Оформити РГР та вчасно надіслати викладачу на перевірку файл РГР та файл програми.

---
### Вимоги до розв’язання завдань: <br>
Обидва завдання запрограмувати в одному класі, який має назву `RgrTr11Petr`. В назві класу зашифровано: Rgr – вид роботи; Tr11 – номер групи; Petr – перші 
чотири літери прізвища автора (Петренко П.П.). В даному класі організувати п’ять методів: `main`, `task11` (для перетворення матриці до трикутникового вигляду),
`task12` (для отримання значень невідомих змінних СЛАР), `task13` (для виведення виводу результатів розрахунку завдання 1), `task2` (для рішення завдання 2). <br>
В методі main організувати:
- введення даних для завдання 1 (додаток 1). Введення даних зробити за допомогою присвоєння;
- виклик методу task11, в який передати початкову розширену матрицю системи лінійних алгебраїчних рівнянь (СЛАР) та повернути трикутникову
матрицю. В даному методі організувати прямий хід методу Гауса для розв’язання СЛАР. За необхідності програмування вкладених циклів,
використовувати принаймні два різних оператори циклів – або for, або while, або do while;
- прийняти із методу task11 трикутникову матрицю;
- викликати метод task12, в який передати трикутникову матрицю та повернути вектор результатів розв’язання СЛАР. В даному методі організувати зворотний хід 
- методу Гауса для розв’язання СЛАР. За необхідності програмування вкладених циклів, використовувати принаймні два різних оператори циклів – або for, або while, або do while;
- викликати три рази task13, в який передавати по черзі початкову матрицю, трикутникову матрицю, вектор результатів для виводу в консоль.
Вивід має бути із заголовком: «Початкова матриця:», «Трикутрникова матриця:» або «Вектор результатів:». Метод task13 зробити універсальним для
виводу матриць і вектору. Виведення організувати за допомогою метода System.out.printf форматованого виводу значень. Для дробових чисел – не
більше 3 знаків після коми. Цілі числа виводити без коми та нулів після коми;
- введення даних для завдання 2 (додаток 2), розрахунки зробити для трьох різних варіантів вхідних даних, що обирає користувач та вводить с
клавіатури (всього має бути 3 варіанти вхідних даних та 3 варіанти результатів розрахунків). Введення даних зробити за допомогою методів
класу Scanner;
- виклик методу task2, в якому організувати всі розрахунки завдання 2 та організувати повернення результатів в main;
- виведення вхідних даних та результатів розрахунку завдання 2. Виведення організувати за допомогою метода System.out.printf форматованого виводу значень. Для 
дробових чисел – не більше 3 знаків після коми.
---
### Вимоги до розв’язання завдання №1: <br>
Система лінійних алгебраїчних рівнянь (СЛАР) задана розширеною матрицею системи. Розв’язати СЛАР методом Гауса. Вивести на екран: початкову матрицю, т
рикутникову матрицю, вектор результатів.
![task1]()

### Вимоги до розв’язання завдання №1: <br>
Розв’язати задачу згідно обраного варіанту. Вивести на екран початкові дані та результати обчислень Завдання виконати для трьох різних вхідних даних.
`Вивести натуральне число та визначити кількість непарних цифр числа`