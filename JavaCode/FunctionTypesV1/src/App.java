import java.io.Console;
import java.util.Scanner;
public class App {

   
    public static void main(String[] args) throws Exception {
         //function call or invoking

            ////1 Without Return Type and Without Parameters
           //Sum();

            // //2 With Return Type and Without Parameters
            // int result1 = Sum1();
            // //output
            // System.out.println("Result is : "+ result1);

            // //3 Without Return Type and With Parameters
            // int a = 45;
            // int b = 55;
            // Sum2(a, b);

            //Sum2(12, 13);

            //Sum2(Sum1(), Sum1());

            //4 With Return Type and With Parameters - pure function (High reuse)

            // int result = Sum3(10, 15);
            // System.out.println("My result is : "+ result);


               Scanner sc= new Scanner(System.in);
            System.out.println("Enter the first number: ");
            int first = sc.nextInt();
            System.out.println("Enter the second number: ");
            int second = sc.nextInt();
            int result1=Sum3(first, second);
             System.out.println("My result is : " + result1);



    }


            //write your methods here


        //1 Without Return Type and Without Parameters - OOP
        //input dependent and output dependent
        public static void Sum()
        {

            //input
            //int i = 10;
            //int j = 20;
             Scanner sc= new Scanner(System.in);
            System.out.println("Enter the first number: ");
            int first = sc.nextInt();
            System.out.println("Enter the second number: ");
            int second = sc.nextInt();


            //process

            int result = first + second;

            //output

            System.out.println(result);
        }

        //2 With Return Type and Without Parameters
//input dependent and output independent
        public static int Sum1()
        {
            //input
            //int i = 10;
            //int j = 20;
            Scanner sc= new Scanner(System.in);
                System.out.println("Enter the first number: ");
                int first = sc.nextInt();
                System.out.println("Enter the second number: ");
                int second = sc.nextInt();


            //process

            int result = first + second;

            //output
            return result;
           
        }


        //3 Without Return Type and With Parameters
//input independent and output dependent
        public static void Sum2(int i, int j)
        {
            //input - comes from parameters
          
            //process

            int result = i + j;

            //output

           System.out.println("Printing from inside the method: "+ result);
        }

        //4 With Return Type and With Parameters - pure function (High reuse)
        //input independent and output independent
        public static int Sum3(int i, int j)
        {
            return i + j;
        }
}
