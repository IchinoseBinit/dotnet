using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class OperatorsProgram : Random
    {
            private int firstNum;
            private int secondNum;

            public OperatorsProgram() { }

            public OperatorsProgram(int firstNum, int secondNum)
            {
                this.firstNum = firstNum;
                this.secondNum = secondNum;
            }

            public void ShowNumbers()
            {
                Console.WriteLine(firstNum + ", " + secondNum);
            }

            public static int operator -(OperatorsProgram value, OperatorsProgram secondValue)
            {
                //OperatorsProgram temp = new OperatorsProgram();
                //temp.firstNum = - value.firstNum;
                //temp.secondNum = - value.secondNum;
                var sumFirst = value.firstNum + value.secondNum;
                var sumLast = secondValue.firstNum + secondValue.secondNum; 

                return sumFirst- sumLast;
            }
        }
}
