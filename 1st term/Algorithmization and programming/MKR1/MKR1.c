#include <stdio.h>
#include <stdbool.h>

 int main(void){
 int matrix[3][3];
 float det = 0;
 printf("\nEnter the matrix:\n");
 for(int i = 0; i < 3; i++){
   for(int j = 0; j < 3; j++){
    scanf("%d", &matrix[i][j]);
  }
 }
 printf("\nThe matrix is:");
 for(int i = 0; i < 3; i++){
 printf("\n");
 for(int j = 0; j < 3; j++){
 printf("%d  ", matrix[i][j]);
 }
}

for(int i = 0; i < 3; i++)
det = det + (matrix[0][i] * (matrix[1][(i+1)%3] * matrix[2][(i+2)%3] - matrix[1][(i+2)%3] * matrix[2][(i+1)%3]));
 printf("\nReversed matrix: \n");
 for(int i = 0; i < 3; i++){
 for(int j = 0; j < 3; j++){
 printf("%.2f\t",((matrix[(j+1)%3][(i+1)%3] * matrix[(j+2)%3][(i+2)%3]) - (matrix[(j+1)%3][(i+2)%3] * matrix[(j+2)%3][(i+1)%3]))/ det);
 printf("\n");
 }
 }
return 0;
}
