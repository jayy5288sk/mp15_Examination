using System;

public class SelectCategory
{
    public SelectCategory()
    {
        Console.WriteLine("1.버거 2.사이드 3.음료");
    }
    
    public Category _selectCategory;
    
    public Category ChooseCategory()
    {
        int _intSelected = ConsoleInput.ReadIntInRange("어떤 것을 고르시겠습니까?: ", 1, 3);
        _selectCategory = (Category)_intSelected;
        
        return _selectCategory;
    }
}