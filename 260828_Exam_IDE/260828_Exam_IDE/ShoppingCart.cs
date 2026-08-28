using System.Collections.Generic;

public class ShoppingCart<T>
{
    public T[] items = new T[] { };
    public int itemCount = 1;
    public int totalCost = 0;
    public string[] itemName;

    public ShoppingCart()
    {
        Console.WriteLine("=== 장바구니 ===");
    }
    public void Add(T item)
    {
        items[itemCount] = item;
        itemCount++;
    }

    public void AllRemove()
    {
        itemCount = 0;
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