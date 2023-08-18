
public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Ternary Demo");

            System.out.println("8 : " + GetSign(8));
            System.out.println("-8 : " + GetSign(-8));
            System.out.println("0 : " + GetSign(0));



            System.out.println("8 : " + GetSignWithZero(8));
            System.out.println("-8 : " + GetSignWithZero(-8));
            System.out.println("0 : " + GetSignWithZero(0));



            System.out.println("1,a :" + GetColor(1, 'a'));
            System.out.println("4,c :" + GetColor(4, 'c'));
            System.out.println("6,f :" + GetColor(6, 'f'));
            System.out.println("8,h :" + GetColor(8, 'h'));
            System.out.println("8,g :" + GetColor(8, 'g'));
            System.out.println("3,d :" + GetColor(3, 'd'));
    }

            public static String GetColor(int row, char col)
        {
            return (row + col) % 2 == 0 ? "Black" : "White";
     
        }

        public static String GetSign(int i)
        {
            return i >= 0 ? "Positive" : "Negative";
        }


        public static String GetSignWithZero(int i)
        {
            return i >= 0 ? (i > 0 ? "Positive" : "Zero") : "Negative";

        }
}
