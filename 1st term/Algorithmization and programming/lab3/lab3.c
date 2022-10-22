#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#define M_PI 3.14159265358979323846264338327950288
#define ln(x) log(x)

void task1 (){
 float min, max, step;
 float a, b, x;
 float y = 0;
   printf("\n ________________________");
 printf("\n      First exercise   \n");
 printf("Enter the range [min,max]: \n");
 scanf("%f%f", &min, &max);
 printf("Enter the value for the step: \n");
 scanf("%f", &step);
 printf("Enter the values for a, b and x: \n");
 scanf("%f%f%f", &a, &b, &x);
 printf("      The results are: \n");

 if(min<max){
   for( min = min; min < max; min += step){
     float value = min+step;
     y = sqrt(ln(a*value-b))+1/(tan(value));
     if(a*x>b){
     printf("           %.3f\n",y);
     } else {
       printf ("error, must be a*x>b\n");
     }
   }
   } else {
     printf("Error, min value must be less than max value\n");
   }
}


int factorial(int n) {
int f = 1;
for (int i = 1; i <= n; i++) {
  f *= i;
}
return f;
}

void task2(){
 float eps = 0.001;
 float y=0;
 int f = 1;
 float x;
 float sum;
 printf("\n ________________________");
 printf("\n      Second exercise   \n");
 printf("Enter x: \n");
 scanf("%f", &x);
 printf("Enter eps: \n");
 scanf("%f", &eps);
 do  {
   y = (pow(f*x, f))/((exp(f))*factorial(f+1)); 
   printf("     %d =%.3f\n", f, y);
   f++;
   sum += y;
 }
 while(y >= eps);
 printf("     sum is:%.3f \n",sum);
}

int main(){
 task1();
 task2();
}
