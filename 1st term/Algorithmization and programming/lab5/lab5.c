#include <stdio.h>
#include <stdlib.h>

int task1(){
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
printf("\n\n\t\tResults of the task \n\n");
task1();
}
