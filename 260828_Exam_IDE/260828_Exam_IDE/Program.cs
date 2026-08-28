using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        bool isNotEnd = true;

        while(isNotEnd)
        {
            SelectCategory selectCategory = new SelectCategory();
            selectCategory.ChooseCategory();

            int cost = selectCategory._costApply;
            string name = selectCategory._selectMenuName;
            Console.WriteLine();
            
            Console.WriteLine("계속 쇼핑하시겠습니까?");
            int keepShopping = ConsoleInput.ReadIntInRange(": ", 1, 2);
            
            if (keepShopping == 1)
            {
                continue;
            }
            else
            {
                isNotEnd = false;
            }
        }
    }
    
}