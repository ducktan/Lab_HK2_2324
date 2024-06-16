#include <stdio.h>
int main(){
  int i, num; 
  int j = 1;
  printf("Enter the number: ");
  scanf ("%d", &num );
  for (i=1; i<num + 1; i++){
    j=j*i;
  }
  printf("The factorial of %d is %d\n", num, j);
  return 0; 
}
