public class Burger : Menu
{
    public int BurgerName = ConsoleInput.ReadIntInRange("버거를 선택해주세요.", 1, 3);
    public int Count = ConsoleInput.ReadIntInRange("개수를 선택해주세요.", 1, 10);
        
    public Burger()
    {}
    
    public override void TotalMenuCost()
    {
        
    }
}