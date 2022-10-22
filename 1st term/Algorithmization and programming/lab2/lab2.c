#include <stdio.h>
#include <math.h>

int main() {
 float a = 4;
 float b = 0.7;
 float x = 0;
 float y;
  if (x<2 && (x+b)>0) {
    y = 1/sinh(b+x);
     printf("\n Результатом обчислення є \n y=%f", y);
 }  else if (x>5) {
    y = tan(a*b+x);
   printf("\n Результатом обчислення є \n y=%f", y);
 }  else if (x>=2 && x<=5) {
    y = (a*b)/sin(x);
   printf("\n Результатом обчислення є \n y=%f", y);
 }  else {
   printf("\n Введені значення не задовольняють жодну з умов");
 }

printf("\n\nБудь ласка, введіть значення a, b та x: \n");
 scanf("%f%f%f", &a, &b, &x);

if (x<2 && (x+b)>0) {
    y = 1/sinh(b+x);
     printf("\n Результатом обчислення є \n y=%f \n ", y);
 } else if (x>5) {
    y = tan(a*b+x);
   printf("\n Результатом обчислення є \n y=%f \n", y);
 } else if (x>=2 && x<=5) {
    y = (a*b)/sin(x);
   printf("\n Результатом обчислення є \n y=%f \n", y);
 }  else {
   printf("\n Введені значення не задовольняють жодну з умов, будь ласка, перевірте аби (x+b)>0");
 }
}
