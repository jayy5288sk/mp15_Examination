class system;

class Program
{
    private const string SHOP_NAME = "버거킥";
    
    static void Main(string[] args)
    {
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 8);
        int payLeast = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
        
    }
}