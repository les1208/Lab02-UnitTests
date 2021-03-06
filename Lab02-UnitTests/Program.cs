﻿using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;

namespace Lab02_UnitTests
{
   public class Program
    {
        public static decimal StartingBal = 777;
        
            /// <summary>
            /// 
            ///<summary>
        public static void Main(string[] args)
        {
            GringottsWizardingBank();
        }

        /// <summary>
        /// this method is the menu for the user to make selection on what they want to do. 
        /// </summary>
        public static void GringottsWizardingBank()
            {
            Console.WriteLine("Welcome to Gringotts, you are now at the main menu. Please make a selection 1, 2, 3, or 4");
            string userInput = Console.ReadLine();
            if (userInput == "1") MakeDeposit();
            if (userInput == "2") WithdrawGalleons();
            if (userInput == "3") CheckBalance();
            if (userInput == "4") Exit();
            Console.Clear();
        
        }

        /// <summary>
        /// This method lets user deposit money into their starting bal.
        /// </summary>

        public static void MakeDeposit()
        {
            try 
                {
                Console.WriteLine("Please enter deposit amount.");
                string userInput = Console.ReadLine();
                decimal input = Convert.ToDecimal(userInput);
                //AddDeposit(input);
                Console.WriteLine($"You have deposited ${userInput}. Press key to cont...");
                Console.ReadLine();
                }
            catch (Exception e)
            {
                AvadaKedavra();
                throw (new Exception(e.Message));
            }
            finally 
            {
                Console.WriteLine("Deposit menu");
                GringottsWizardingBank();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void WithdrawGalleons()
        {
            try 
            {
                Console.WriteLine("Withdraw amount..");
                string userInput = Console.ReadLine();
                decimal input = Convert.ToDecimal(userInput);
                //Withdraw(input);
                if (StartingBal < 0)
                    {
                       userInput = null;
                       Console.WriteLine("Insufficient galleons");
                       Console.ReadLine();
                       GringottsWizardingBank();
                }
            }

            catch (Exception)
            {   
                AvadaKedavra();
                throw;
            }
        }

        /// <summary>
        /// User is able to check balance here.
        /// </summary>
       
        public static void CheckBalance()
        {
            try
            {
                Console.WriteLine($"There is ${StartingBal} available. ");
                GringottsWizardingBank();
            }
            catch (Exception)
            {
                AvadaKedavra();
                GringottsWizardingBank();
            }
        }

        /// <summary>
        /// This method exits the user out of Gringotts.
        /// </summary>
        public static void Exit()
        {    
            try 
            {
                Console.WriteLine("See ya you Muggle!");
            }
            catch (Exception b)
            {
                AvadaKedavra();
                throw (new Exception(b.Message));
            }
        }

        public static void AvadaKedavra()
        {
            Console.WriteLine("Error....");
        }

    }


}
