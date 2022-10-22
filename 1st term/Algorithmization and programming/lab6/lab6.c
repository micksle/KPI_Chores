#include <stdio.h>

int main (){
int s = 0;             //ініціалізуємо змінні для обрахунку довжини речення, крайнього положення заміненого елементу
int t = 0;
char str[50];
char symb[50];
char target[50];
char temp[50];
char result[50];

printf("\n enter string to edit: \n");  
fgets(str, 50, stdin);                             //зчитуємо речення, з яким будемо працювати

printf("\n enter the symbols that will be changed \n");
scanf("%s", target);                               //зчитуємо набір символів, які необхідно змінити

printf("\n enter new symbol \n");
scanf("%s", symb);                               //зчитуємо символ(и), на які буде змінено

while(str[s] != '\0') {
 s++;                                    //рахуємо довжину початкової строки
}

while(target[t] != '\0') {
 t++;                                    //рахуємо кінцеве положення, в якому  міститься останній замінений компонент
}
for(int i = 0; i < 50; i++){             //копіюємо частину речення, що не змінюється
 temp[i] = str[t];
 t++;
}

for(int i = 0; str[i] != '\0'; i++){     //замінюємо заданий набір символів на інший
 if(str[i] == target[i]){
   str[i] = symb[i];
 }
}

printf("\n edited string -  %s%s\n", str, temp);   //виводимо результат у консоль
return 0;
}
