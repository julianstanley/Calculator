﻿using System;

namespace SimpleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int convertedInputToNumber;
            //int.TryParse(input, out convertedInputToNumber);

            Person person1 = new Person();
            Console.WriteLine(person1.getAge()); 
            person1.setAge(29);
            Console.WriteLine(person1.getAge());

            Person.greet();
        }
    }
}
