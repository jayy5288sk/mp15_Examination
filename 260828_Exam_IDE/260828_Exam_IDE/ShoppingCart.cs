using System.Collections.Generic;

public class ShoppingCart<T> where T : Menu
{
    public int itemCost = 0;
    public int totalCost;
    public string[] itemName;
    private T[] TArray;
    private int InStorage;

    public ShoppingCart(int capacity)
    {
        TArray = new T[capacity];
    }
    public int AddCost(int itemCount)
    {
        itemCost *= itemCount;
        totalCost = itemCost;
        return totalCost;
    }

    public void AllRemove()
    {
        
    }

    public void BuyItemsInCart(int money)
    {
        Console.WriteLine($"총 금액은 {totalCost}입니다.");
        ConsoleInput.ReadIntAtLeast(": ", totalCost);
        if (money > totalCost)
        {
            money -= totalCost;
            AllRemove();
            Console.Clear();
            Console.WriteLine($"구매 완료했습니다. 거스름돈은 {money}입니다.");
        }
        
    }
}