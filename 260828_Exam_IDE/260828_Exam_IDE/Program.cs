class system;

class Program
{
    private const string SHOP_NAME = "버거킥";
    private const int COUNT_MENU_DISCOUNT = 3;
    private const double DISCOUNT_VALUE = 0.9;
    static void Main(string[] args)
    {
        Console.WriteLine($"어서오세요. {SHOP_NAME}입니다.");
        
        SelectCategory selectCategory = new SelectCategory();
        selectCategory.ChooseCategory();
    }
    
}