public abstract class Menu
{
    protected string MenuName;
    protected int MenuCost;
    protected Category MenuCategory;

    public Menu(string name, int cost, Category category)
    {
        MenuName = name;
        MenuCost = cost;
        MenuCategory = category;
    }

    public abstract void TotalMenuCost();
}