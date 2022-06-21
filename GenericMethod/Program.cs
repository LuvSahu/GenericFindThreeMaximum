namespace Generics
{
    class Program
    {
        public static void Main(String[] args)
        {
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //char[] charArray = { 'a', 'b', 'c', 'd', 'f' };

            // For Method-
            //GenericMethodArray.toPrint<int>(intArray);
            //GenericMethodArray.toPrint<double>(doubleArray);
            //GenericMethodArray.toPrint<char>(charArray);

            // For Class
            //new GenericClassArray<int>(intArray).toPrint();
            //new GenericClassArray<double>(doubleArray).toPrint();
            //new GenericClassArray<char>(charArray).toPrint();

            //int Intoutput = UC1_MaxThreeIntNum.MaximumIntegerNumber(178, 56, 90);
            //Console.WriteLine(/*"Maximum Integer Number : ",*/ Intoutput);

            //double doubleoutput = UC1_MaxThreeIntNum.MaximumfloatNumber(77.45, 256.78, 90.45);
            //Console.WriteLine(/*"Maximum Float Number : ",*/ doubleoutput);

            //string stroutput = UC1_MaxThreeIntNum.MaximumstringNumber("ViratKholi", "MSDhoni", "SachinTendulkar");
            //Console.WriteLine(/*"Maximum Float Number : ",*/ stroutput);

            UC1_MaxThreeIntNum method = new UC1_MaxThreeIntNum();

            Console.WriteLine(method.intMax(50, 39, 22));
            Console.WriteLine(method.floatMax(50.2, 39.2, 2.2));
            Console.WriteLine(method.FindMaxString("ViratKholi", "MSDhoni", "SachinTendulkar"));

            Refactor1 result = new Refactor1();
            result.ToMax<int>(3, 4, 2);
            result.ToMax<double>(3.3, 4.2, 2.1);
            result.ToMax<string>("ViratKholi", "MSDhoni", "SachinTendulkar");



            new Refactor2<int>(3, 4, 5).FindMax();
            new Refactor2<double>(3.3, 4.2, 5.6).FindMax();
            new Refactor2<string>("ViratKholi", "MSDhoni", "SachinTendulkar").FindMax();



        }
    }
}