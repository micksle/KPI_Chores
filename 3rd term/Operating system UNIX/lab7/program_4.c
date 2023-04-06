#include <pthread.h>
#include <stdio.h>
#include <unistd.h>
#include <math.h>
#include <stdlib.h>
#define SIZE_I 2
#define SIZE_J 2

float X[SIZE_I][SIZE_J];
float S[SIZE_I][SIZE_J];
int count = 0; 										// глобальний лічильник

struct DATA_ {
 double x;
 int i;
 int z;
};

typedef struct DATA_ DATA;
pthread_mutex_t lock; 									// Блокування

double f(double x) {									// Функция для вычислений
return x*x;
}

void *calc_thr (void *arg) {								// Потокова функція для обчислень
 	DATA* a = (DATA*) arg;
 	X[a->i][a->z] = f(a->x);
 	pthread_mutex_lock(&lock); 							// установка блокування
 	count ++; 									// зміна глобальної змінної
 	pthread_mutex_unlock(&lock); 							// зняття блокування
 	free(a);
 	return NULL;
}

void *input_thr(void *arg) {								// Потокова функція для введення
 	DATA* a = (DATA*) arg;
 	printf("S[%d][%d]:", a->i, a->z);
 	scanf("%f", &S[a->i][a->z]);
 	free(a);
 	return NULL;
}

int main() {
	pthread_t thr[ SIZE_I * SIZE_J ];						//масив ідентифікаторів потоків
	pthread_mutex_init(&lock, NULL);						// ініціалізація м’ютекса
	DATA *arg;

	for (int i = 0; i < SIZE_I; i++) {							// Введення даних для обробки
		for (int z = 0; z < SIZE_J; z++) {
 		arg = (DATA*)malloc(sizeof(DATA));
 		arg->i = i;
 		arg->z = z;
		pthread_create (&thr[ i* SIZE_J + z ], NULL, input_thr, (void *)arg);	// створення потоку для введення елементів матриці
		} // for (int z=0; z<SIZE_J; P ++z)
	} 
// Очікування завершення усіх потоків введення даних

// ідентифікатори потоків зберігаються у масиві thr
	for(int i = 0; i < SIZE_I*SIZE_J; i++) {
		pthread_join (thr[i], NULL);
	}
	pthread_t thread;								// Обчислення елементів матриці
	printf("Start calculation\n");
	for (int i=0;i<SIZE_I; i++) {
 		for (int z=0; z<SIZE_J; z++) {
 			arg = (DATA*)malloc(sizeof(DATA));
 			arg-> i = i;
 			arg-> z = z;
 			arg-> x = S[i][z];
 			pthread_create (&thread, NULL, calc_thr, (void *)arg);		 // створення потоку для обчислень
			pthread_detach(thread);						 // переведення потоку у режим від’єнання
		}
	}
	do {
		printf("finished %d threads\n", count);					// Перевірка стану обчислень
	} while ( count < SIZE_I*SIZE_J);						// Виведення результатів
	for (int i = 0; i < SIZE_I; i++) {
 		for (int z = 0; z<SIZE_J; z++) {
 			printf("X[%d][%d] = %f\t", i, z, X[i][z]);
		}
		printf("\n");
	}
	pthread_mutex_destroy(&lock);							// видалення м’ютекса
	return 0;
}