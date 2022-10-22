using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class Exceptions
    {
        static void Main()
        {

            // This block raises an exception
            try
            {

                byte data = byte.Parse("a");
                Console.WriteLine(data);
            }

            // Catch block 1

            // This block is used to handle
            // IndexOutOfRangeException type exception
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("At least provide one Argument!");
            }

            // Catch block 2

            // This block is used to handle
            // FormatException type exception
            catch (FormatException)
            {

                Console.WriteLine("Entered value in not a number!");
            }

            // Catch block 3

            // This block is used to handle
            // OverflowException type exception
            catch (OverflowException)
            {

                Console.WriteLine("Data is out of Range!");
            }
        }
    }
}
