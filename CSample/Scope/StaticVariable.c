#include<stdio.h>

int increment()
{
    static int count=0;
    count=count+5;
    return count;
}

 void main()
{
    printf("%d\n",increment());
    printf("%d\n",increment());
    printf("%d\n",increment());
    printf("%d\n",increment());
}
