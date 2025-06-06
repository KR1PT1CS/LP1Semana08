﻿using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
          {
         private readonly int movement;
         public virtual int Health { get; set; }
         public abstract float Cost { get; }
 
         public Unit(int movement, int health)
         {
             this.movement = movement;
             Health = health;
         }
 
         public void Move()
         {
             string romanNumeral = ConvertToRoman(movement);
             Console.WriteLine($"Unit moved {romanNumeral} spaces");
         }
 
         private string ConvertToRoman(int number)
         {
             if (number <= 0) return "N/A";
             
             string[] thousands = { "", "M", "MM", "MMM" };
             string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
             string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
             string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
 
             return thousands[number / 1000] + 
                    hundreds[(number % 1000) / 100] + 
                    tens[(number % 100) / 10] + 
                    ones[number % 10];
         }
     }
 }
  