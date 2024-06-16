#include <pthread.h> 
#include <stdio.h> 
#include <semaphore.h> 

int sells = 0; 
int products = 0; 

sem_t sem; 


void *processA(void *mess){
	while(1){
		// truoc khi tang sell, kiem tra ben product co lon > sell k
		// ban dau sem = 0 --> chuyen qua processB
		// dua vao hang doi block 
		sem_wait(&sem); 
		sells++; 
		printf("SELLs = %d\n", sells); 
		}
		// A chay cho den khi het timeslice
		// khi sem chay ve bang 0
}

void *processB(void *mess){
	while (1){
		products++; 
		printf("PRODUCTs = %d\n", products); 
		sem_post(&sem);
		// tang sem len 1 va giai phong processA
	}
}


int main(){
	sem_init(&sem, 0, 0);
	pthread_t pA, pB; 
	pthread_create(&pA, NULL, &processA, NULL); 
	pthread_create(&pB, NULL, &processB, NULL); 
	
	while(1){}
	return 0; 
}
