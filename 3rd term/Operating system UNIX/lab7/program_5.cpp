#include <iostream>
#include <semaphore.h>  
#include <fstream>
#include <stdio.h>
#include <error.h>

void* WriteToFile(void*);
int errno;
sem_t psem;
std::ofstream qfwrite;

int main(int argc, char **argv) {
	pthread_t tidA,tidB;
	int n;
	char filename[] = "./result.txt";
	qfwrite.open(&filename[0]);
	sem_init(&psem,0,0);
	sem_post(&psem);
	pthread_create(&tidA,NULL,&WriteToFile,(void*)100);
 	pthread_create(&tidB,NULL,&WriteToFile,(void*)100);
 	pthread_join(tidA,NULL);
 	pthread_join(tidB,NULL);
	sem_destroy(&psem);
	qfwrite.close();
}

void* WriteToFile(void *f){
	int max = (int)(size_t) f;
	for (int i=0; i<=max; i++){
 		sem_wait(&psem);
 		qfwrite<<pthread_self()<<"-writetofilecounter i="<<i<<std::endl;
 		qfwrite<<std::flush;
 		sem_post(&psem);
	}
	return NULL;
} 