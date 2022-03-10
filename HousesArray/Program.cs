using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HousesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] housesOriginalState = { 0, 1, 1, 0, 0, 1, 1, 0 };

            int[] housesNewState = getStateArray(housesOriginalState, 5);


            Console.WriteLine("New state");
            for (int i = 0; i < housesNewState.Length; i++)
            {
                Console.Write($"[{housesNewState[i]}] ");
            }

            Console.ReadKey();
        }

        public static int[] getStateArray(int[] housesStates, int days)
        {
            if (days == 0)
                return housesStates;
            int leftValue = 0;
            int rightValue = 0;
            for (int i = 0; i < housesStates.Length; i++)
            {
                if (i == housesStates.Length - 1)
                    rightValue = 0;
                else
                    rightValue = housesStates[i + 1];

                if (leftValue == rightValue)
                {
                    leftValue = housesStates[i];
                    housesStates[i] = 0;
                }
                else
                {
                    leftValue = housesStates[i];
                    housesStates[i] = 1;
                }
            }
            getStateArray(housesStates, days - 1);
            return housesStates;
        }
    }
}
