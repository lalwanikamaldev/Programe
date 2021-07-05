using System;

namespace FirstConsoleApplication
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Input YOur First Number"); // print
           
            int a =  Int32.Parse(Console.ReadLine()); // readline , int() => int32.parse();

        //  1. prgrame 
            //   electicityBillGenerationPrograme();


            // THis programe will print series like 2,1,4,3,6,5.......n,n-1 ;
            ForLoopSeriesPrograme();

            IfStatement.ifStatementFunction1();
            IfStatement.ifStatementFunction2();


            //int firstNumber =4; // find type of right object replace left var to right object type int
            //var secondNumber = 6;
            //var thirdNumber = 0;

            //var c = SumNumber(firstNumber, secondNumber); // 1 liner 

            //Console.WriteLine(c);

        }

        // void => perform the operation  but won't return the value ;
        // long/string/float/double/int  => this make sure the result should return ;
        public static void PrintMyName(string myname)
        {
            Console.WriteLine(myname);
           // Console.WriteLine("My name is");
          //  Console.Write("Kamal");
        }

        public static int SumNumber(int a,int b)
        {

            return a + b;

          //  Console.WriteLine(myname);
            // Console.WriteLine("My name is");
            //  Console.Write("Kamal");
        }

        public static int electicityBillGenerationPrograme()
        {
          //  ljfcjhfhsjkfhkjsaaf'a'f

          //      afhafhlkahflahflkafh
            return 0;
        }

        /// <summary>
        ///  THis programe will print series like 2,1,4,3,6,5.......n,n-1 ;
        /// </summary>
        public static void ForLoopSeriesPrograme()
        {
             
        }
    }
}
