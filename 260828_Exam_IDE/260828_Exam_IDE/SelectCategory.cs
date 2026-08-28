using System;

public class SelectCategory
{
    private const string SHOP_NAME = "버거킥";
    public SelectCategory()
    {
        Console.WriteLine($"어서오세요. {SHOP_NAME}입니다.");
    }
    
    public Category _selectCategory;
    
    public void ChooseCategory()
    {
        Console.WriteLine("1.버거 2.사이드 3.음료");
        int _intSelected = ConsoleInput.ReadIntInRange("어떤 것을 고르시겠습니까?: ", 1, 3);
        
        _selectCategory = (Category)_intSelected;
        
        Console.Clear();
        
        if (_intSelected == 1)
        {
            Burger burger = new Burger();
            burger.TotalMenuCost();
        }
        else if (_intSelected == 2)
        {
            Side side = new Side();
            side.TotalMenuCost();
        }
        else
        {
            Console.WriteLine("품절");
        }
    }
}