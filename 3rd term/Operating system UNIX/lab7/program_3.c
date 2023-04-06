#include <pthread.h>
#include <unistd.h>
#include <stdio.h>

pthread_mutex_t count_mutex;
long count;

void *increment_count(void *arg) {
 	pthread_mutex_lock(&count_mutex);
 	count = count + 1;
 	pthread_mutex_unlock(&count_mutex);
 	return NULL;
}

long get_count() {
 	long c;
 	pthread_mutex_lock(&count_mutex);
 	c = count;
 	pthread_mutex_unlock(&count_mutex);
 	return (c);
}

int main(void)
{
	pthread_t thread[2];
	pthread_mutex_init(&count_mutex, NULL);
 	pthread_create(&(thread[1]), NULL, increment_count, NULL);
 	printf("count value: %ld\n", get_count());
 	pthread_create(&(thread[2]), NULL, increment_count, NULL);
 	printf("count value: %ld\n", get_count());
 	return 0;
}