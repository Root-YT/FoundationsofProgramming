#include<stdio.h>
#include<math.h>
#include<stdlib.h>
#include<time.h>

void main()
{
    // //int overflow
    // int i=2147483647;
    // int j=2147483647;
    // long long k= (long long)i + j;  //-2 
    // printf("%lld\n", k);


    // int i=10;
    // int j=3;
    // float k= (float)i/j;
    // printf("%f\n", k);

    // double result= sqrt(24);
    // printf("%lf\n", result);

    // double result= pow(5,3);
    // printf("%lf\n", result);
    // printf("%lf\n", pow(10, 5));
    // printf("%lf\n", pow(2, 15));

    // int i= -5;
    // int result= (int)fabs(i);
    // printf("%d", result);
    srand(time(0));
    int temp= rand()%100; // within range 0 to 99
    printf("%d\n", temp);
    printf("%d\n", rand());
    printf("%d\n", rand());
    printf("%d\n", rand());

}