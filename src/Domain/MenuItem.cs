public class MenuItem : MenuSystemItem
{
    public MenuItem(string title, string url, string icon = "") : base(title, url, icon)
    {
    }

    public override void Render(int indent = 0) => Console.WriteLine($"{new string(' ', indent * 2)}{Icon} {Title} ({Url})");

    public override int CountItems() => 1;
}