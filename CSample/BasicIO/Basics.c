#include<stdio.h>
#include<stdbool.h>

void main()
{
    puts("Welcome to Code demo"); //unformatted
    char name[20];
    puts("Enter your name: ");
    //scanf("%s", name);
    gets(name);
    printf("Your name is : %s\n", name);

    int age;
    puts("Enter your age: ");
    scanf("%d", &age);
    printf("Your age is : %d\n", age);
    
    float height;
    puts("enter your height: ");
    scanf("%f", &height);
    printf("Your height is %f\n", height);

    double salary;
    puts("Enter your salary: ");
    scanf("%lf", &salary);
    printf("Your salary is %f\n", salary);

    bool married;

    puts("Are your married? Type 0 (false) or 1 (True): ");
    scanf("%d", &married);

    printf("Are you married? : %d\n", married);

    printf("Welcome. Your name is %s. Your age is %d. Your height is %0.2f. Your salary is %8.4f. Married? %d", name, age, height, salary, married  );

   
}