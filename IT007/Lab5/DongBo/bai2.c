#include <stdio.h> 
#include <pthread.h> 
#include <stdlib.h> 
#include <time.h> 

int* a; 
int n; 
int curr = 0;

void Arrange(int *a, int x) {
	if (x == curr) {
		curr--; 
	} 
	
	else {
		for (int i = x; i < curr - 1; i++) {
			a[i] = a[i + 1]; 
		}
		curr--; 
	}
}

void *processA(void *mess) {
	while (1) {
		srand((int)time(0)); 
		a[curr] = rand(); 
		curr++; 
		printf("So phan tu trong a la %d\n", curr); 
	}
}


void *processB(void *mess){
	while (1) {
		srand((int)time(0)); 
		if (curr == 0){
			printf("Nothing in array\n"); 
		}
		else {
			int r = rand() % curr; 
			Arrange(a, r); 
			printf("So phan tu cua a sau khi lay ra la %d\n", curr); 
		}
	}
}



int main(){
	printf("Nhap so phan tu: \n"); 
	scanf("%d", &n); 
	a = (int*)malloc(n*sizeof(int));
	pthread_t pA, pB; 
	pthread_create(&pA, NULL, &processA, NULL); 
	pthread_create(&pB, NULL, &processB, NULL);
	while(1) {}
	return 0;
}
	
