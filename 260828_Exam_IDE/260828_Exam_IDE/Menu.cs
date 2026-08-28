public abstract class Menu
{
    public int MenuEach { get; }
    public int MenuCost { get; }
    public Menu()
    {}
    public abstract int TotalMenuCost();
}