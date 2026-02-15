public abstract class MenuSystemItem
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public bool IsActive { get; set; }

    public MenuSystemItem(string title, string url, string icon = "")
    {
        Title = title;
        Url = url;
        Icon = icon;
        IsActive = true;
    }

    public abstract void Render(int indent = 0);
    public abstract int CountItems();
}