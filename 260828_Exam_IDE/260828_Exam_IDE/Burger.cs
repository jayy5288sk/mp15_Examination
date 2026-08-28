public class Burger : Menu
{
    public BurgerName BurgerName;
    public Burger()
    {
        Console.WriteLine("어떤 버거를 선택하십니까?");
        Console.WriteLine("1. 스탠다드 와퍼");
        Console.WriteLine("2. 몬스터 와퍼");
        Console.WriteLine("3. 주니어 와퍼");
    }
    
    public override int TotalMenuCost()
    {
        int totalCost = 0;
        int _intBurgerName = ConsoleInput.ReadIntInRange(": ", 1, 3);
        
        BurgerName = (BurgerName)_intBurgerName;

        int picked = ConsoleInput.ReadIntInRange($"{BurgerName}을 몇 개 구매하십니까?", 1, 10);

        if (_intBurgerName == 1)
        {
            totalCost = picked * 8000;
        }
        else if (_intBurgerName == 2)
        {
            totalCost = picked * 12000;
        }
        else
        {
            totalCost = picked * 6000;
        }
        
        Console.WriteLine($"{BurgerName} {picked}개 {totalCost}원 입니다.");
        
        return totalCost;
    }
}