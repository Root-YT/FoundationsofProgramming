public class App {
    public static void main(String[] args) throws Exception {
        //System.out.println("Hello, World!");

        Example e1= new Example();
        e1.A();
        e1.B();
    }
}


 class Example
    {
        int i = 10; //non-static field, instance field or object field - global

        public void A()
        {
            int j = 30; //local variable or method variable
            System.out.println(j);
            System.out.println(i);
            int i = 20; //redeclaring i as local variable - hides global variable i
            System.out.println(i);
        }
        public void B()
        {
            System.out.println(i);
        }
    }
