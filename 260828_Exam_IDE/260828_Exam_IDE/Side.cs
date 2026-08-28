using System;

public class Side : Menu
{
    private const int COUNT_MENU_DISCOUNT = 2;
    private const double DISCOUNT_VALUE = 0.9;
    
    public SidesName SideName;
    
    public Side()
    {
        Console.WriteLine("사이드는 어떤 것을 원하십니까?");
        Console.WriteLine("1. 감자튀김 3,000원");
        Console.WriteLine("2. 너겟킥 4,000원");
        Console.WriteLine("3. 코코넛 새우킥 6,000원");
    }
    
    public override int TotalMenuCost()
    {
        int totalCost = 0;
        int _intSideName = ConsoleInput.ReadIntInRange(": ", 1, 3);
        
        SideName = (SidesName)_intSideName;

        int picked = ConsoleInput.ReadIntInRange($"{SideName}을 몇 개 구매하십니까?", 1, 10);
        
        if (_intSideName == 1)
        {
            totalCost = picked * 8000;
        }
        else if (_intSideName == 2)
        {
            totalCost = picked * 12000;
        }
        else
        {
            totalCost = picked * 6000;
        }
        
        Console.WriteLine($"{SideName} {picked}개 {totalCost}원 입니다.");
        
        return totalCost;
    }
}