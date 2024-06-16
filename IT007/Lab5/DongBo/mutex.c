#include <pthread.h> 
#include <stdio.h> 

int products = 0; 
pthread_mutex_t mutex;

void *processA(void *mess){
	while (1) {
		pthread_mutex_lock(&mutex);
		if (products > 0)
			products--; 
		printf("SELL process | products = %d\n", products); 
		pthread_mutex_unlock(&mutex);
	}
}

void *processB(void *mess){
	while (1) {
		pthread_mutex_lock(&mutex);
		products++; 
		printf("PRODUCE process | products = %d\n", products); 
		pthread_mutex_unlock(&mutex);
	}
}

int main(){
	pthread_mutex_init(&mutex, NULL);
	pthread_t pA, pB; 
	pthread_create(&pA, NULL, &processA, NULL); 
	pthread_create(&pB, NULL, &processB, NULL);
	
	while(1){};
	return 0;
}

