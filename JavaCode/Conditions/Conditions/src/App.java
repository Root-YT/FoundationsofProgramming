public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("If Else Demo");
        // int age = 34;

        // if (age > 17) {
        // System.out.println("Can Vote");
        // } else {
        // System.out.println("Can't Vote");
        // }

        int age = 65;
        if (age >= 18 && age <= 60) {
        System.out.println("Can Work");
        } else {
        System.out.println("Can't Work");
        }

        int income = 500000;
        if (income <= 500000) {
        System.out.println("No Tax");
        } else if (income > 500000 && income <= 1000000) {
        System.out.println("10% tax");
        } else if (income > 1000000 && income <= 2000000) {
        System.out.println("20% Tax");
        } else if (income > 2000000) {
        System.out.println("30% tax");
        } else {
        System.out.println("Invalid Input Value");
        }

    }
}
