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
            
            Console.WriteLine($"계속 쇼핑하시겠습니까?");
            Console.WriteLine("1.YES 2.NO");
            int keepShopping = ConsoleInput.ReadIntInRange(": ", 1, 2);
            Console.Clear();
            if (keepShopping == 2)
            {
                isNotEnd = false;
            }
        }
    }
    
}