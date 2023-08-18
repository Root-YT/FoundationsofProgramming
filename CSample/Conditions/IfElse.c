#include<stdio.h>

int GetInteger(char *msg)
{
    puts(msg);
    int age;
    scanf("%d", &age);
    return age;
}

void main()
{
    //limit check

    const int VOTINGAGE = 18;
    int userage= GetInteger("Enter your age: ");
    if(userage>=VOTINGAGE)
    {
        puts("Can Vote");
    }
    else
    {
        puts("Can't Vote");
    }


    int empage= GetInteger("Enter your age: ");
    if(empage>=18 && empage<=60)
    {
        puts("You are eligible to work");
    }
    else
    {
        puts("You are not eligible to work");
    }


    int income=GetInteger("Enter your income: ");

    if(income<=500000)
    {
        puts("No tax");
    }
    else if(income>500000 && income<=1000000)
    {
        puts("10\% tax");
    }
        else if(income>1000000 && income<=2000000)
    {
        puts("20\% tax");
    }
    else if(income> 2000000)
    {
        puts("30\% tax");
    }
    else
    {
        puts("Invalid income value");
    }

}

