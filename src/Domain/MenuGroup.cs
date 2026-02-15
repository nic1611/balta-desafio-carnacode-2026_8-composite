public class MenuGroup : MenuSystemItem
{
    private List<MenuSystemItem> Items = new();

    public MenuGroup(string title, string icon = "") : base(title, "", icon)
    {
    }

    public void Add(MenuSystemItem component) => Items.Add(component);

    public void Remove(MenuSystemItem component) => Items.Remove(component);

    public MenuSystemItem GetChild(int index) => Items[index];

    public override void Render(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent * 2)}{Icon} {Title} ▼");
        foreach (var item in Items)
        {
            item.Render(indent + 2);
        }
    }

    public override int CountItems()
    {
        int count = 0;
        foreach (var item in Items)
        {
            count += item.CountItems();
        }
        return count;
    }
}