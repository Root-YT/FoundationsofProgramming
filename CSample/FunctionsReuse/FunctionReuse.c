#include<stdio.h>


int GetInteger(char *msg)
{
    puts(msg);
    int temp;
    scanf("%d", &temp);
    return temp;
}

double GetDouble(char *msg)
{
    puts(msg);
    double temp;
    scanf("%lf", &temp);
    return temp;
}

float GetFloat(char *msg)
{
    puts(msg);
    float temp;
    scanf("%f", &temp);
    return temp;
}

void main()
{
    puts("Welcome to Function reuse demo");
    int age= GetInteger("Enter youe age: ");
    printf("Your age is %d\n", age);

    float height= GetFloat("Enter your height: ");
    printf("Your height is : %f\n", height);

    double radius= GetDouble("Enter the radius: ");
    printf("The radius is %lf\n", radius);
}