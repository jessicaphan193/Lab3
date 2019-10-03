﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declaration
            int myInt;
            long myLong = 0;
            double myDouble = 0.0;
            string myStr = "some text";
            #endregion declaration

            #region printing p. 63-67
            //build errors and warnings
            //Console.WriteLine("myInt: {0}", myInt);

            Console.WriteLine("myLong:    {0}", myLong);
            Console.WriteLine("myLong c:  {0:c}", myLong);
            Console.WriteLine("myLong d:  {0:d}", myLong);
            Console.WriteLine("myLong d6: {0:d6}", myLong);
            Console.WriteLine("myLong x:  {0:x}", 31);
            Console.WriteLine();
            #endregion

            #region casting p. 88-90
            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1);
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);
            Console.WriteLine();
            #endregion

            #region strings p. 79-88
            string hello = "hello";
            string world = "world;";
            string str;

            Console.WriteLine("length of hello: {0}", hello.Length);
            Console.WriteLine("test ==: {0}", hello == "hello2");
            Console.WriteLine("test ==: {0}", hello == "hello");
            Console.WriteLine("test ==: {0}", hello.Equals("hello"));

            Console.WriteLine("compare: {0}", hello.CompareTo(world));
            Console.WriteLine("compare: {0}", hello.CompareTo(hello));

            // concatentation
            str = hello + "" + world;
            Console.WriteLine(str);

            // verbateim
            str = @"c:\\myApp\\bin\\debug";
            string str2 = "c:\\myApp\\bin\\debug";

            Console.WriteLine(str);
            Console.WriteLine(str2);


            #endregion
        }
    }
}
