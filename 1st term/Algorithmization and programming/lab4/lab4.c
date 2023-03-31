#include <stdio.h>
#include <stdlib.h>

float  task1(){
int l;
printf("Enter the length of the matrix: ");
scanf("%d", &l);
float x[l];
printf("Enter the matrix: \n");
for(int i = 0; i < l; i++){
scanf("%f", &x[i]);
}
int positive;
for(int j = 0; j < l; j++)
if(x[j] > 0){
 positive = j;
 break;
}
for(int i = 0; i < positive; i++){
 for(int j = 0; j < positive; j++){ 
   if(x[j] > x[j+1]){          
     int t = x[j];
     x[j] = x[j+1];
     x[j+1] = t;
   }
 }
}
printf("\nSorted matrix: \n\n");
for(int i = 0; i < l; i++){
  printf("%.1f  ", x[i]);
}
return 0;
} 

int main(void){
printf("\t\tThe result of the algorithm\n\n");
task1();
}
