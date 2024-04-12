﻿using System;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8

            // 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;

            // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;


            // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;

            // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;

            // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;

            // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;


            // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;

            // 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;

            // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;

            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);



            // string myString = "Hello World";
            // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // Console.WriteLine(myStringWithSymbols);

            // bool myBool = true;


            string[] myArr = ["potatoes", "try"];
            // Console.WriteLine(myArr);
            string[] secondArr = ["first", "second"];
            // Console.WriteLine(secondArr);

            List<string> groceryList = ["Milk", "Cheese"];
            List<int> numberList = [2, 2];


            groceryList.Add("Added");

            Console.WriteLine(groceryList[0]);
            Console.WriteLine(groceryList[1]);
            Console.WriteLine(groceryList[2]);


            IEnumerable<string> myEnum = groceryList;
            Console.WriteLine(myEnum.First());

            string[,,] myTwoDArr = new string[,,]{
                {{"test"}, {"test"}},
                {{"test"}, {"test"}},

            };

            Console.WriteLine(myTwoDArr[0, 0, 0]);


            Dictionary<string, string[]> myDicteonary = new() {
                {"Cheese",["Dairy","Test"]},
                {"Milk",["test"]}
            };

            Dictionary<string, double> myTestP = new Dictionary<string, double>(){
                {"cheese",5.99d},
                {"carrots",2.99d}
            };


            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>(){
                {"cheese",5.99m},
                {"carrots",2.99m}
            };
            Console.WriteLine(myDicteonary["Cheese"][1]);
            Console.WriteLine(myDicteonary["Milk"][0]);
            Console.WriteLine(Math.Pow(5, 2));
        }
    }
}