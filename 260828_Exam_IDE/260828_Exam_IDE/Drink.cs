public class Drink : Menu
{
    public int totalCost;
    public DrinkName DrinkName;
    
    public Drink()
    {
        Console.WriteLine("음료는 어떤 것을 원하십니까?");
        Console.WriteLine("1. 콜라 2,000원");
        Console.WriteLine("2. 제로 콜라 2,500원");
    }
    
    public override int TotalMenuCost()
    {
        int _intDrinkName = ConsoleInput.ReadIntInRange(": ", 1, 2);
        
        DrinkName = (DrinkName)_intDrinkName;
        
        Console.Clear();

        Console.WriteLine($"{DrinkName}을 몇 개 구매하십니까?");
        int picked = ConsoleInput.ReadIntInRange($": ", 1, 10);
        
        if (_intDrinkName == 1)
        {
            totalCost = picked * 2000;
        }
        else
        {
            totalCost = picked * 2500;
        }
        
        Console.Clear();
        Console.WriteLine($"{DrinkName} {picked}개 {totalCost}원");
        
        return totalCost;
    }
    
    public string ConvertName()
    {
        string name = DrinkName.ToString();

        return name;
    }
}