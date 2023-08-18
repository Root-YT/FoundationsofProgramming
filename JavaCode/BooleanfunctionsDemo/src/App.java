public class App {
    public static void main(String[] args) throws Exception {
       // System.out.println("Hello, World!");
        // System.out.println("5: "+IsEven(5));
        // System.out.println("4: "+IsEven(4));

        System.out.println("5: "+IsOdd(5));
        System.out.println("4: "+IsOdd(4));
    }


    public static boolean IsEven(int N)
    {
        return N%2==0;
    }

    public static boolean IsOdd(int N)
    {
        return !IsEven(N);
    }
}
