using System;

public class SelectCategory
{
    private const string SHOP_NAME = "버거킥";
    
    public Category _selectCategory;
    public int _costApply;
    public string _selectMenuName;
    
    public SelectCategory()
    {
        Console.WriteLine($"어서오세요. {SHOP_NAME}입니다.");
        Console.WriteLine();
    }
    
    public void ChooseCategory()
    {
        Console.WriteLine("어떤 것을 고르시겠습니까?");
        Console.WriteLine("1.버거 2.사이드 3.음료");
        int _intSelected = ConsoleInput.ReadIntInRange(": ", 1, 3);
        
        _selectCategory = (Category)_intSelected;
        
        Console.Clear();
        
        if (_intSelected == 1)
        {
            Burger burger = new Burger();
            _costApply = burger.TotalMenuCost();
            _selectMenuName = burger.ConvertName();
        }
        else if (_intSelected == 2)
        {
            Side side = new Side();
            _costApply = side.TotalMenuCost();
            _selectMenuName = side.ConvertName();
        }
        else
        {
            Drink drink = new Drink();
            _costApply = drink.TotalMenuCost();
            _selectMenuName = drink.ConvertName();
        }
    }
}