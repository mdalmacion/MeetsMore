// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{

    public static void Main(string[] args)
    {
        int paymentDue = 0;
        int cashInserted = 0;
        int change = 0;

        Console.Write("Payment due: ");
        paymentDue = Int32.Parse(Console.ReadLine());
        Console.Write("Cash inserted: ");
        cashInserted = Int32.Parse(Console.ReadLine());
        change = CalculateChange(paymentDue, cashInserted);
        if (change < 0)
        {
            Console.WriteLine("Cash inserted is less than the payment due");
        }
        else
        {
            Console.WriteLine("Change due: " + change.ToString());
            CalculateBillsAndCoins(change);
        }


    }

    public static int CalculateChange(int paymentDue, int cashInserted)
    {
        return (cashInserted - paymentDue);
    }

    public static void CalculateBillsAndCoins(int change)
    {
        int[] bills = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 }; //bills and coins 
        int[] billCounter = new int[10]; //counter for each bills and coins 
        int i = 0; //counter for billCounter
        int currValue = change;
        for (int j = 0; j < 10; j++)
        {
            if ((currValue - bills[j] >= 0)) //current bill can be subtracted from change 
            {
                
                //subtract bill from change until possible
                while (currValue > 0)
                { 
                    int temp = currValue - bills[j];
                    if (temp < 0) 
                    {
                        break;
                    }
                    else 
                    {
                        currValue = temp;
                        billCounter[j]++;
                    }
                }

            }

        }
        foreach(var element in bills)
        {
            string temp = "note";
            if (element < 1000)
            {
                temp = "coin";
            }
            if (billCounter[i] != 0)
            {
                Console.WriteLine("" + element + " yen" + temp + " * " + billCounter[i]);
            }
             i++;
        }

    }


}
