import java.util.Scanner;
public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Post Condition Loop");
        Scanner sc = new Scanner(System.in);
         String input = "";
        do {
            System.out.println("Enter the first number: ");
            int first = Integer.parseInt(sc.nextLine());
            System.out.println("Enter the second number: ");
            int second = Integer.parseInt(sc.nextLine());
            int result = first + second;
            System.out.println(result);
            System.out.println("Do you want to continue? Press Yes to Continue");
            input = sc.nextLine();
        } while (input.equals("Yes")); 
    }
}
