import java.util.Scanner;
public class App {
    public static void main(String[] args) throws Exception {
        // double length = GetDouble("Enter the length: ");
        //     double width = GetDouble("Enter the width: ");

            
        //     PrintMessage("Area is : " + GetArea(length, width));


        double amount = GetDouble("Enter the bill amount: ");
        PrintMessage("The tips to be paid is : " + CalcTips(amount));


    }

    public static double CalcTips(double amount)
    {
        return 5.0 / 100.0 * amount;
    }


    public static double GetArea(double length, double width)
    {
        double area = length * width;
        return area;
    }

      public static void PrintMessage(String message) 
        {
            System.out.println(message);
        }

        public static String GetLine()
        {
            Scanner sc= new Scanner(System.in);
            return sc.nextLine();
        }

        public static int GetInteger(String message)
        {
            PrintMessage(message);
            int temp = Integer.parseInt(GetLine());
            return temp;
        }

        public static float GetFloat(String message)
        {
            PrintMessage(message);
            float temp = Float.parseFloat(GetLine());
            return temp;
        }

        public static long GetLongInteger(String message)
        {
            PrintMessage(message);
            long temp = Long.parseLong(GetLine());
            return temp;
        }

        public static double GetDouble(String message)
        {
            PrintMessage(message);
            double temp = Double.parseDouble(GetLine());
            return temp;
        }

}
