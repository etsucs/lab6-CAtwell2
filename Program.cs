//Show Character
class showchar
{
   public static char showChar(String s, int n)
   {
       return s.charAt(n);
   }

   public static void main(String args[])
   {
       char c=showChar("New York",2);

       System.out.println(c);
   }
}

//Retail Cost
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeSaleCostCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateRetail();

            Console.ReadLine();
        }

        private static void CalculateRetail()
        {
            double dWholeSaleCostAmount;
            int iPercentage;

            Console.WriteLine("Enter Wholesale Cost Amount");
            double.TryParse(Console.ReadLine(), out dWholeSaleCostAmount);

         
            Console.WriteLine("Enter Markup Percentage");
            int.TryParse(Console.ReadLine(), out iPercentage);

            if (dWholeSaleCostAmount > 0 && iPercentage > 0)
            {
             
                double dMarkup = dWholeSaleCostAmount * (iPercentage / (double)100);

                double dRetailPrice = dMarkup + dWholeSaleCostAmount;

                if (dWholeSaleCostAmount > 500)
                {
                    dRetailPrice -= 20;
                }

            Console.WriteLine("Retail Price: $" + dRetailPrice );
         }
        else
        {
      Console.WriteLine("Invalid Cost or Percentage");
 }
 }
 }
}

//Temp Table

#include <stdio.h>


float celsius(float F){
return (5*(F-32))/9;
}
float farenheit(float C){
return ((9*C)/5) + 32;
}
int main(void) {
   // your code goes here
   printf("Converting into celsius\n");
   for(int i=0;i<=20;i++){
   printf("%d : %fC\n",i,celsius(i));
   }
  
   printf("Converting into farenheit\n");
   for(int i=0;i<=20;i++){
   printf("%d : %fF\n",i,farenheit(i));
   }
  
   return 0;
}




//Prime Numbers

namespace PrimeNumber
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}

//IsPrime
private static bool IsPrime(int number)
{
// basic case
if (number <= 1) return false;
if (number == 2) return true;
if (number % 2 == 0) return false;

// get boundary square root of number
var boundary = (int)Math.Floor(Math.Sqrt(number));

// check if the number divides between 2 and sqrt(num)
for (int i = 3; i <= boundary; i += 2)
if (number % i == 0)
return false;

return true;
}