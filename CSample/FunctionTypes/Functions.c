#include<stdio.h>

void main()
{
   // Sum();

    // int ans= Sum1();
    // printf("%d\n", ans);

    //Sum2(10, 15);

    int result= Sum3(15, 16);
    printf("%d\n", result);
    printf("%d\n", Sum3(45, 55));
}

  void Sum()
        {
            //input
            //int i = 10;
            //int j = 20;
            printf("Enter the first number: ");
            int first;
            scanf("%d", &first);
            printf("Enter the second number: ");
            int second;
            scanf("%d", &second);


            //process

            int result = first + second;

            //output

            printf("%d\n",result);
        }


         int Sum1()
        {
            //input
            //int i = 10;
            //int j = 20;
              printf("Enter the first number: ");
            int first;
            scanf("%d", &first);
            printf("Enter the second number: ");
            int second;
            scanf("%d", &second);


            //process

            int result = first + second;

            //output
            return result;
           
        }


         //3 Without Return Type and With Parameters

         void Sum2(int i, int j)
        {
            //input - comes from parameters
          
            //process

            int result = i + j;

            //output

            printf("Printing from inside the method: %d\n", result);
        }

         //4 With Return Type and With Parameters - pure function (High reuse)

        int Sum3(int i, int j)
        {
            return i + j;
        }