#include<stdio.h>

void main()
{
    int x=-5;
    // if(x>=0)
    // {
    //     puts("Positive");

    // }
    // else{
    //     puts("Negative");
    // }

   // puts(x>=0?"Positive":"Negative");

     puts(x>=0?(x==0?"Zero":"Positive"):"Negative");
}