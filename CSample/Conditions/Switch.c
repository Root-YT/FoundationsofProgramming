#include<stdio.h>

void main()
{
    int x=1;
    
    switch(x)
    {
        case 1: 
            puts("Its one");
            break;
        case 2:
            puts("Its Two");
            break;
        case 3:
             puts("Its Three");
             break;
        default:
            puts("Someother number");
            break;
    }
}