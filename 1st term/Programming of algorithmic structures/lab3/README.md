# Тема: Програмування циклічних алгоритмів
### Варіант: 16

1. Розробити блок-схеми алгоритмів і написати програми мовою Java із застосуванням операторів циклів for, while, do while для розв’язання завдань,
поданих в табл. 1 – 3 відповідно до індивідуального варіанта. Варіант обрати за списком групи;
2. Розробити програмні проекти в середовищі Intellij IDEA для реалізації написаних програм. Перевірити результати обчислень альтернативними
розрахунками (наприклад, Excel, калькулятор, тощо);
3. Зробити Звіт з лабораторної роботи та вчасно надіслати викладачу на перевірку.

---
### Вимоги до розв’язання завдання 1: <br>
- Розробити програму табулювання (дослідження) функцій y = f(x) та u = f(x), змінюючи x на заданому проміжку із заданим кроком h. Завдання
вибрати з табл. 1 відповідно до індивідуального варіанта.
- Обчислення та виведення результатів організувати в методі `task1`, в який слід передати границі заданого діапазону та крок приросту аргументу h.
Результати виводити в таблицю з трьома стовбчиками для х, y(x), u(x).
- Під час виведення результатів застосувати форматований вивід: x – один або два знаки після коми, y(x), u(x) – 4 знаки після коми. <br><br>

y = ${\lg(x/2+0.1)}$;<br>
u = $cos((x+2{\pi})*e^x)$;
x є [0;7], h = 0.2

### Вимоги до розв’язання завдання 2: <br>
- Розробити програму аналізу та обробки числових послідовностей. В якості вхідної числової послідовності обрати будь-яку послідовність чисел,
що задовольняє умові завдання згідно із обраним варіантом. Кількість чисел має бути не менше 10. Введення даних організувати простим присвоєнням.
- В методі main має бути тільки введення даних, виклик методу task2 (або, за необхідності, task21, task 22, task 23…), виведення початкових даних та
результатів обчислень.
- В методі `task2` організувати обчислення згідно обраного варіанту завдання та повернення результатів до методу main.
Виведення результатів організувати в методі main за допомогою форматованого виводу значень. Для дробових чисел – не більше 4 знаків після коми.
Завдання 2 вирішити для двох різних послідовностей чисел.
```
Вивести послідовність натуральних чисел та обчислити подвоєну суму усіх додатних членів послідовності
```

### Вимоги до розв’язання завдання 3: <br>
- Розробити блок-схему алгоритму та програму обчислення суми або добутку членів ряду (табл. 3). Обчислення здійснити для двох значень змінної
х: х1 = 0,6; х2 = 2,8. Введення даних організувати з клавіатури за допомогою методів класу Scanner.
- В методі main має бути тільки введення даних, виклик методу task3 (або, за необхідності, task31, task 32, task 33…), виведення початкових даних та
результатів обчислень.
- В методі `task3` організувати обчислення згідно обраного варіанту завдання із застосуванням двох різних операторів циклу – або for, або while,
або do while. Виведення результатів організувати за допомогою форматованого виводу значень. Для дробових чисел – не більше 4 знаків після коми. 
$$\left (y = \sum_{k=1}^5 (x^(k+2)) / (k!) \right)$$
