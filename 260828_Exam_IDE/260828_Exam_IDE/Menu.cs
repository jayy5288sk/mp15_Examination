public abstract class Menu
{
    protected int MenuName;
    protected int MenuCost;
    protected Category MenuCategory;

    public Menu()
    {}

    public abstract void TotalMenuCost();
    
    /*public Category CheckMenuCategory()
    {
        int category = 0;
        ConsoleInput.ReadIntInRange("항목을 선택해주세요.", 1, 3);
        MenuCategory = (Category)category;
        return MenuCategory;
    }*/
}