﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserReg
{
    public class validation
    {
        public static string FirstName = "^[A-Z]{1}[a-z]{3,}$";
        public static string LastName = "^[A-Z]{1}[a-z]{3,}$";
        public static string Email = "^[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string Phone_Number = "^[9][1][ ][6-9]{1}[0-9]{9}$";
        public static string Password = "^[a-zA-Z0-9]{8}$";
        public static string Password1 = "^(?=.*[A-Z])[a-zA-Z0-9]{8}$";
        public static string Password2 = "^(?=.*[0-9])[a-zA-Z0-9]{8}$";
        public static string Password3 = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$";


        public static bool Check(string name)
        {
            return Regex.IsMatch(name, FirstName);
        }
        public static bool Check2(string name1)
        {
            return Regex.IsMatch(name1, LastName);
        }
        public void ValidateEmail(string mail)
        {
            Regex reg = new Regex(Email);
            bool valid = reg.IsMatch(mail);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePhone(string phone)
        {
            Regex reg = new Regex(Phone_Number);
            bool valid = reg.IsMatch(phone);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePassword(string password)
        {
            Regex reg = new Regex(Password);
            bool valid = reg.IsMatch(password);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePassword1(string password1)
        {
            Regex reg = new Regex(Password1);
            bool valid = reg.IsMatch(password1);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePassword2(string password2)
        {
            Regex reg = new Regex(Password2);
            bool valid = reg.IsMatch(password2);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePassword3(string password3)
        {
            Regex reg = new Regex(Password3);
            bool valid = reg.IsMatch(password3);
            if (valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
