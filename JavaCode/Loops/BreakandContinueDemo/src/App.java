public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Break and Continue Statements");

        for (int i = 0; i < 10; i++) {
        if (i % 3 == 0) {
        continue; // skips the remaining program and goes directly to increment
        }
        System.out.println(i);
        }

        for (int i = 0; i < 10; i++) {
        if (i == 7) {
        break; // stops the loops and exits
        }
        System.out.println(i);
        }
    }
}
