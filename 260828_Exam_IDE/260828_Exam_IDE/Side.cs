using System;

public class Side : Menu
{
    private const int COUNT_MENU_DISCOUNT = 3;
    private const int DISCOUNT_VALUE = 200;
    
    public int totalCost;
    public SidesName SideName;
    public int sideCount;
    public int discountValue;
    
    public Side()
    {
        Console.WriteLine("사이드는 어떤 것을 원하십니까? (★ 4개 이상 할인 적용 ★)");
        Console.WriteLine("1. 감자튀김 3,000원");
        Console.WriteLine("2. 너겟킥 4,000원");
        Console.WriteLine("3. 코코넛 새우킥 6,000원");
    }
    
    public override int TotalMenuCost()
    {
        int _intSideName = ConsoleInput.ReadIntInRange(": ", 1, 3);
        
        SideName = (SidesName)_intSideName;
        
        Console.Clear();

        Console.WriteLine($"{SideName}을 몇 개 구매하십니까?");
        sideCount = ConsoleInput.ReadIntInRange($": ", 1, 10);
        if (sideCount > COUNT_MENU_DISCOUNT)
        {
            discountValue =  sideCount * DISCOUNT_VALUE;
        }
        if (_intSideName == 1)
        {
            totalCost = (sideCount * 3000) - discountValue;
        }
        else if (_intSideName == 2)
        {
            totalCost = (sideCount * 4000) - discountValue;
        }
        else
        {
            totalCost = (sideCount * 6000) - discountValue;
        }
        
        Console.Clear();
        Console.WriteLine($"{SideName} {sideCount}개 {totalCost}원");
        
        return totalCost;
    }
    public string ConvertName()
    {
        string name = SideName.ToString();

        return name;
    }
    public int MenuEach
    {
        get
        {
            return sideCount;
        }
    }
    
    public int MenuCost
    {
        get
        {
            return totalCost;
        }
    }
}