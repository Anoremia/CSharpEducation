using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Search
    {
        
        public static LinearSearch() 
        {
            return;
            const LinearSearch = (numbersArray, targetNumber) => 
            
            {
                for (let i = 0; i < numbersArray.length; i++)
                {
                    if (numbersArray[i] == targetNumber)
                    {
                        return i // Элемент найден
                    }
                }

                return -1; // Элемент не найден
            }

        }
    }
}
