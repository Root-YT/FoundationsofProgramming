
public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Boolean Functions Demo");


            System.out.println("1992: "+IsLeapYear(1992));
            System.out.println("1996: " + IsLeapYear(1996));
            System.out.println("2004: " + IsLeapYear(2004));
            System.out.println("1991: " + IsLeapYear(1991));
            System.out.println("2003: " + IsLeapYear(2003));
            System.out.println("2000: " + IsLeapYear(2000)); 
            System.out.println("1900: " + IsLeapYear(1900));
    }


       public static boolean IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        public static boolean IsATypicalCommonYear(int year)
        {
            return year % 100 == 0 && year % 400 != 0;
        }

        public static boolean IsLeapYear(int year)
        {
            return IsTypicalLeapYear(year) && !(IsATypicalCommonYear(year));
        }
}
