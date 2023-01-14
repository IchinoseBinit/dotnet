using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CustomArray<T>
    {
    
        int size = 5;
        T[] array = new T[5];
        // declare
        
        int count = 0 ;

        public void Add(T instance)
        {
            if (count < size )
            {
                array[count] = instance;
                count++;
            }
            else {
                Console.WriteLine("Already reached the maximum count");
            }
        }

        public void ToString()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
