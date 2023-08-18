#include<stdio.h>

void main()
{
    int i=0; //init the iterator

    Print:
        printf("%d\n", i); //business logic
        i=i+1; //increment
        if(i<=10) //condition
        {
            goto Print;
        }

    printf("Loop is done");
}