using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class ShuffleCards
{
    static void Main(string[] args)
    {
        string[] secretBase = {
                              "CHU", // 0
                              "TEL", // 1
                              "OFT", // 2
                              "IVA",
                              "EMY", // 4
                              "VNB",
                              "POQ",
                              "ERI",
                              "CAD",
                              "K-A",
                              "IIA",
                              "YLO", 
                              "PLA"  // 12
                              };

        string input = Console.ReadLine();

        string[] inputArray = new string[input.Length / 3]; // new array to put each "number" from the input (strings with 3 lenght)


        for (int i = 0, j = input.Length / 3 -1 ; i < input.Length; i += 3, j--) //to split the "numbers"
        {

            inputArray[j] = input.Substring(i , 3);

        }

        long[] indexDigits = new long[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int y = 0; y < secretBase.Length; y++)
            {
                if (inputArray[i] == secretBase[y])
                {
                    indexDigits[i] = y;
                    continue;
                }
            }
        }

        long finalDecimal = 0;
        for (int i = 0; i < indexDigits.Length; i++)
        {
            finalDecimal += indexDigits[i] * (long)Math.Pow(13, i);
        }

        Console.WriteLine(finalDecimal);
        //      TELERIK-ACADEMY  = 45569    ; IVAYLO = 50       
    }
}

