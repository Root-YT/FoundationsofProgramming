public class App {
    public static void main(String[] args) throws Exception {
            System.out.println("Switch Demo");
            System.out.println("1 : " + GetDay(1));
            System.out.println("15 : " + GetDay(15));
            System.out.println("14 : " + GetDay(14));
            System.out.println("12 : " + GetDay(12));
            System.out.println("27 : " + GetDay(27));
            System.out.println("31 : " + GetDay(31));
            System.out.println("30 : " + GetDay(30));
            System.out.println("11 : " + GetDay(11));
        
    }

     public static String GetDay(int N)
        {
            String day = "";
          
            switch(N%7) //0-6
            {
                case 1:
                    day = "Monday";
                    break; //c# mandatory, optional in c and java -  fall through
                case 2:
                    day= "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday"; 
                    break;
                case 0:
                    day = "Sunday";
                    break;
                default:
                    day = "Not valid"; //Write no Business Logic here , only use for error messages
                    break;

            }
            return day;
        }
}
