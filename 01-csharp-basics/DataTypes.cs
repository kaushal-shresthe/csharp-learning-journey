using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _01_csharp_basics
{
    internal class DataTypes
    {
        public static void Run()
        {
            //*** Byte Data Type in C# ***

            //Two Types -> 1. Unsigned Byte Data Type(byte), 2. Signed Byte Data Type (sbyte)
            byte b1 = 66;
            // We Cannot store negative number using byte data type.
            //The following statement will give compile time error
            //byte b2 = -100;
            //The following Statement will give compile time error
            //The maximum value we can store in a byte variable is 255
            //byte b3 = 256;
            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Equivalent Character of {b1} is {(char)b1}");
            Console.WriteLine($"Byte Min Value:{byte.MinValue} and Max Value:{byte.MaxValue}");
            Console.WriteLine($"Byte Size:{sizeof(byte)} Byte");

            sbyte sb1 = 123;
            //We can store negative number using sbyte data type.
            //The following statement will not give compile time error
            sbyte sb2 = -101;
            //The following Statement will give compile time error
            //The maximum value we can store in a sbyte variable is 127
            //sbyte sb3 = 128;
            //The following Statement will give compile time error
            //The minimum value you can store in a sbyte variable is -128
            //sbyte sb4 = -129;
            Console.WriteLine($"\nDecimal: {sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb1} is {(char)sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb2} is {(char)sb2}");
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");
            Console.WriteLine();

            // *** Char Data Type in C# ***
            char ch = '$';
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"Equivalent Number: {(byte)ch}");
            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Char Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"Size of Char: {sizeof(char)} Byte");
            Console.WriteLine();

            // *** String Data Type in C# ***
            string str = "Learn CSharp";
            var howManyBytes = str.Length * sizeof(char);
            Console.WriteLine($"str Value: {str}");
            Console.WriteLine($"str Size: {howManyBytes}");
            Console.WriteLine();

            // *** Numeric Data Type in C# ***
            //Numbers without Decimal:
            // For Signed Number
            //1. 16 - Bit Signed Numeric: Example: Int16 or short
            //2. 32 - Bit Signed Numeric: Example: Int32 or int
            //3. 64 - Bit Signed Numeric: Example: Int64 or long

            Int16 num1 = 123;
            Int32 num2 = 456;
            Int64 num3 = 789;
            Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");
            Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
            Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");
            Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
            Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");
            Console.WriteLine();

            // For Unsigned Number
            //1. 16 - Bit UnSigned Numeric: Example: UInt16 or ushort
            //2. 32 - Bit UnSigned Numeric: Example: UInt32 or uint
            //3. 64 - Bit UnSigned Numeric: Example: UInt64 or ulong

            //UInt16 num1 = 123;
            ushort unum1 = 123;
            //UInt32 num2 = 456;
            uint unum2 = 456;
            // UInt64 num3 = 789;
            ulong unum3 = 789;
            Console.WriteLine($"ushort Min Value:{ushort.MinValue} and Max Value:{ushort.MaxValue}");
            Console.WriteLine($"short Size:{sizeof(ushort)} Byte");
            Console.WriteLine($"uint Min Value:{uint.MinValue} and Max Value:{uint.MaxValue}");
            Console.WriteLine($"uint Size:{sizeof(uint)} Byte");
            Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value:{ulong.MaxValue}");
            Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");
            Console.WriteLine();

            //Numeric Numbers with Decimal in C#:
            //1. Single or float(single - precision floating - point number)  (4 Byte)
            //2. Double or double(double - precision floating - point number)  (8 Byte)
            //3. Decimal or decimal (Represents a decimal floating - point number)  (16 Byte)

            Single a = 1.123f;
            Double b = 1.456;
            Decimal c = 1.789M;

            Console.WriteLine($"Single Size:{sizeof(Single)} Byte");
            Console.WriteLine($"Single Min Value:{Single.MinValue} and Max Value:{Single.MaxValue}");
            Console.WriteLine($"Double Size:{sizeof(Double)} Byte");
            Console.WriteLine($"Double Min Value:{Double.MinValue} and Max Value:{Double.MaxValue}");
            Console.WriteLine($"Decimal Size:{sizeof(Decimal)} Byte");
            Console.WriteLine($"Decimal Min Value:{Decimal.MinValue} and Max Value:{Decimal.MaxValue}");
            Console.WriteLine();

            // For Accuracy
            float aa1 = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
            double ab1 = 1.78986380830029492956829698978655434342477; //15 digits Maximum
            decimal ac1 = 1.78986380830029492956829698978655434342477m; //29 digits Maximum
            Console.WriteLine(aa1);
            Console.WriteLine(ab1);
            Console.WriteLine(ac1);
            Console.WriteLine();

            // Get the Default Values of built-in Data Types in C#
            Console.WriteLine($"Default Value of Byte: {default(byte)} ");
            Console.WriteLine($"Default Value of Integer: {default(int)}");
            Console.WriteLine($"Default Value of Float: {default(float)}");
            Console.WriteLine($"Default Value of Long: {default(long)}");
            Console.WriteLine($"Default Value of Double: {default(double)}");
            Console.WriteLine($"Default Value of Character: {default(char)}");
            Console.WriteLine($"Default Value of Boolean: {default(bool)}");
            Console.WriteLine();
        }

        //Data Types impact the application performance in C# Language
        public static void ImpactofDataTypes()
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                short s1 = 100;
                short s2 = 100;
                short s3 = 100;
            }
            stopwatch1.Stop();
            Console.WriteLine($"short took : {stopwatch1.ElapsedMilliseconds} MS");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                decimal s1 = 100;
                decimal s2 = 100;
                decimal s3 = 100;
            }
            stopwatch2.Stop();
            Console.WriteLine($"decimal took : {stopwatch2.ElapsedMilliseconds} MS");
            Console.WriteLine();
        }

        public static void CompareIntVsDecimal()
        {
            int iterations = 10_000_000;
            Stopwatch sw = new Stopwatch();

            // 1. Using INT (Very Fast)
            sw.Start();
            int intSum = 0;
            for (int i = 0; i < iterations; i++)
            {
                intSum += 1;
            }
            sw.Stop();
            Console.WriteLine($"int (Whole Number) took: {sw.ElapsedMilliseconds} ms");

            sw.Reset();

            // 2. Using DECIMAL (Much Slower)
            sw.Start();
            decimal decSum = 0;
            for (int i = 0; i < iterations; i++)
            {
                decSum += 1;
            }
            sw.Stop();
            Console.WriteLine($"decimal (High Precision) took: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine();
        }

        // *** Pointer Type in C# ***
        //public static void PointerDataType()
        //{
        //    unsafe
        //    {
        //        // declare a variable
        //        int number = 10;
        //        // store variable number address location in pointer variable ptr
        //        int* ptr = &number;
        //        Console.WriteLine($"Value :{number}");
        //        Console.WriteLine($"Address :{(int)ptr}");
        //        Console.ReadKey();
        //    }
        //}
    }
}
