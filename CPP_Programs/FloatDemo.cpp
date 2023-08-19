#include <iostream>
#include <cstdio>

using namespace std;
constexpr size_t Byte=8;

int main()
{
    cout<<"Welcome to the Uncertain World of Floating Point Arithmetic"<<endl;
    float f;
    double df;
    long double ldf;

    printf("Size of float f is %ld bits\n", sizeof(f) * Byte);
    printf("Size of double df is %ld bits\n", sizeof(df) * Byte);
    printf("Size of long double ldf is %ld bits\n", sizeof(ldf) * Byte);

    f=500.0;
    printf("Value of f is %f\n", f);

    f=5e2;
    printf("Value of f is %f\n", f);

    f=5e10;
    printf("Value of f is %f\n", f);

    f=5e20;
    printf("Value of f is %f\n", f);

    df= 5e20;
    printf("Value of df is %lf\n", df);

    df=.1+.1+.1;
    if(df==0.3)
    {
        printf("True\n");
    }
    else
    {
       printf("False\n");
    }
    
    printf("Value of df is %lf\n", df);
    printf("Value of df 10 digit is %1.10lf\n", df);
    printf("Value of df 20 digit is %1.20lf\n", df);

    return 0;
}