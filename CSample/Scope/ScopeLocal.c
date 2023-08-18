#include<stdio.h>

int x=10; //global

int sample()
{
    printf("In Sample function: \n");
    printf("%d\n", x);
    x=x+5;
    printf("%d\n", x);
}

 void main()
{
    printf("In Main function: \n");

    sample();
    printf("%d\n",x);
    x=x+3;
    printf("%d\n",x);

    int x=50; //local redeclaration
    printf("%d\n",x);
    sample();
}
