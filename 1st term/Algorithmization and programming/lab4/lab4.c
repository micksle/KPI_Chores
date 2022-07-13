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

int  task2(){
int  matrix[9][9];
printf("Initial matrix:\n\n");
for(int i = 0; i < 9; i++){
 for(int j = 0; j < 9; j++){
   matrix[i][j] = rand()%99;
   printf("%.2d  ", matrix [i][j]);
 }
 printf("\n");
}
printf("\n\nSorted matrix:\n\n");
  
int N = 9 ;
for (int i = 0; i < N/2; ++i){
 for (int j = i; j < N-i-1; ++j){
  int temp = matrix[i][N-1-j];
  matrix[i][N-1-j] = matrix[N-1-j][N-1-i];
  matrix[N-1-j][N-1-i] = matrix[N-1-i][j];
  matrix[N-1-i][j] = matrix[j][i];
  matrix[j][i] = temp;
   }
 }
 for(int i = 0; i < 9; i++){
  for(int j = 0; j < 9; j++){
   printf("%.2d  ", matrix[i][j]);
 }
 printf("\n");
}
return 0 ;
}

int main(void){
printf("\t\tResults of the first task \n\n");
task1();
printf("\n\n\t\tResults of the second task \n\n");
task2();
}
