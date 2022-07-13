#include <stdio.h>
#include <math.h>

int main()
{
 float a, b, x, y;
 printf("Input a b x");
 scanf("%f%f%f", &a, &b, &x);
 if (sqrtl (logf(a*x-b)>0))
 {
   y = sqrt(logf(a*x-b))+1/(tan(x));
   printf("Result y=%f", y);
 }
 else
 {
   printf("logf(a * x - b) > 0");
 }
}
