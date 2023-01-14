using System;
namespace OperatorOverloading
{
    internal class Program 
    { 
        public static void Main(string[] args)
        {
            OperatorsProgram op = new OperatorsProgram(30, 40);
            op.ShowNumbers();
            OperatorsProgram secondOp = new OperatorsProgram(50, 60);
            secondOp.ShowNumbers();
            //secondOp = -op;
            //secondOp.ShowNumbers();
            Console.WriteLine(secondOp - op);

            int a = 20;
            int b = 30;
            b = a - b;
            b -= a;

        }
    }
}