public class App {
    public static void main(String[] args) throws Exception {
            //int x = 5; //101
            //int y = 3; //011

            // System.out.println("OR  : " + (x | y));// 111 =7
            // System.out.println("AND : "+ (x & y)); // 001 = 1
            // System.out.println("XOR : "+ (x ^ y)); // 110 = 6

            //int x = 0;
            //int stairs = 8;
            //x = x | stairs; //to set the bit
            //System.out.println(x);
            //int nonsomking = 32;
            //x = x | nonsomking;
            //System.out.println(x);

            ////check if set = AND with that bitmask

            //System.out.println(x & nonsomking); //greater than 0 means set else not set

            //x = x & (~nonsomking); //to unset a bit
            //System.out.println(x);
            //System.out.println(x & nonsomking);

            //int x = 5;
            //int y = 3;

            //int z = x ^ y;
            //System.out.println(z);
            //System.out.println(z ^ x);
            //System.out.println(z ^ y);


            // int x = 4;

            // System.out.println(x << 1);
            // System.out.println(x << 2);

            int x = 16;

            System.out.println(x >> 1);
            System.out.println(x >> 2);
    }
}
