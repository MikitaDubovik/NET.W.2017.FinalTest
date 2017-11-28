using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Solution;
using Task2.Solution;

namespace Task2.Tests
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            RandomFileGenerator generator = new RandomCharsFileGenerator();
            generator.GenerateFiles(10, 10);
            generator = new RandomBytesFileGenerator();
            generator.GenerateFiles(15, 15);
        }
    }
}
