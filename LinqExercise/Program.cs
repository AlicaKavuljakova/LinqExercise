﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending");
            Console.WriteLine("--------------");
            var nums = numbers.OrderBy(x => x).ToArray();
            foreach (int x in nums) Console.WriteLine(x);
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Descending");
            var desc = numbers.OrderByDescending(x => x);
            foreach (var n in desc) { Console.WriteLine(n); };
            Console.WriteLine("------------");

           
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Greater than 6");
            var greatSix=numbers.Where(x => x > 6);
            foreach (var item in greatSix) { Console.WriteLine(item); };
            Console.WriteLine("another way");
            foreach (var n in numbers.Where(x=>x>6)) { Console.WriteLine(n); }
            Console.WriteLine("------------");
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("first 4 descending");
            foreach (var x in desc.Take(4)) { Console.WriteLine(x);}
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("index 4 number changed to my age");
            var numies = numbers.OrderByDescending(n => n).ToArray();
            numies[4] = 38;
           foreach(var n in numies) Console.WriteLine(n);
            Console.WriteLine("------------");
            // List of employees ****Do not remove this****
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var employees = CreateEmployees();
            var filter = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName.StartsWith('S')).OrderBy(x=>x.FirstName);
            Console.WriteLine("C and S employees :");
            foreach (var n in filter) { Console.WriteLine(n.FullName); }
            Console.WriteLine("-------------------------");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26:");
            var over26=employees.Where(x=>x.Age>26).OrderBy(x=>x.Age).ThenBy(x=>x.FirstName);
            foreach(var person in over26) { Console.WriteLine($"Fullname:{person.FullName}   Age:{person.Age}"); }





            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
           var filtered= employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine("Sum of years of experience of employees over 35 with less than or equal to 10years of experience:");
            Console.WriteLine(filtered.Sum(x => x.YearsOfExperience));
            Console.WriteLine("Average of years of experience of employees over 35 with less than or equal to 10years of experience:");
            Console.WriteLine(filtered.Average(x=> x.YearsOfExperience));
            //TODO: Add an employee to the end of the list without using employees.Add()
           employees= employees.Append( new Employee { FirstName = "Alica", LastName = "Kavuljakova", Age = 38, YearsOfExperience = 1 }).ToList(); 
            foreach(var n in employees) { Console.WriteLine(n.FirstName); }

            Console.WriteLine();

            Console.ReadLine();


            #region CreateEmployeesMethod
            /*private*/ static List<Employee> CreateEmployees()
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
                employees.Add(new Employee("Steven", "Bustamento", 56, 5));
                employees.Add(new Employee("Micheal", "Doyle", 36, 8));
                employees.Add(new Employee("Daniel", "Walsh", 72, 22));
                employees.Add(new Employee("Jill", "Valentine", 32, 43));
                employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
                employees.Add(new Employee("Big", "Boss", 23, 14));
                employees.Add(new Employee("Solid", "Snake", 18, 3));
                employees.Add(new Employee("Chris", "Redfield", 44, 7));
                employees.Add(new Employee("Faye", "Valentine", 32, 10));

                return employees;
            }
            #endregion
        }
    } }
