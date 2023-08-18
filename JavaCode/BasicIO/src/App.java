import java.util.Scanner;
public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Welcome to Java Code Demo");

      //  System.out.println("Demo Code1");
      //  System.out.print("Demo Code2");
        //Object creation
        Scanner sc= new Scanner(System.in);
        System.out.println("Enter your name: ");
        //String name= sc.next(); //space terminated
        String name= sc.nextLine();  // \n terminated
        System.out.println("Your name is "+ name);

        System.out.println("Enter your age: ");
        int age= sc.nextInt();
        System.out.println("Your age is : "+ age);

        System.out.println("Enter your height: ");
        float height= sc.nextFloat();
        System.out.println("Your height is : "+ height);

        System.out.println("Enter your salary: ");
        double salary =sc.nextDouble();
        System.out.println("Your salary is : "+ salary);

        System.out.println("Are you married? ");
        boolean married= sc.nextBoolean();

        System.out.println("Married? "+ married);

        System.out.printf("Welcome %s. Your age is %d. Your height is %.2f. Your salary is %8.2f. Married? %b", name, age, height, salary, married );
    }
}
