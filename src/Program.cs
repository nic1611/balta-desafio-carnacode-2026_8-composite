namespace DesignPatternChallenge;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Menus CMS ===\n");

        var mainMenu = new MenuGroup("Menu Principal", "☰");

        // 1. Adicionando item simples (Leaf)
        var home = new MenuItem("Home", "/", "🏠");
        mainMenu.Add(home);

        // Item simples no nível raiz
        mainMenu.Add(new MenuItem("Home", "/", "🏠"));

        // Grupo com itens
        var productsMenu = new MenuGroup("Produtos", "📦");
        productsMenu.Add(new MenuItem("Todos", "/produtos"));
        productsMenu.Add(new MenuItem("Categorias", "/categorias"));
        productsMenu.Add(new MenuItem("Ofertas", "/ofertas"));

        // Subgrupo dentro de grupo
        var clothingMenu = new MenuGroup("Roupas", "👕");
        clothingMenu.Add(new MenuItem("Camisetas", "/roupas/camisetas"));
        clothingMenu.Add(new MenuItem("Calças", "/roupas/calcas"));

        productsMenu.Add(clothingMenu);

        // Adicionando grupo ao menu principal
        mainMenu.Add(productsMenu);

        // Outro grupo
        var adminMenu = new MenuGroup("Administração", "⚙️");
        adminMenu.Add(new MenuItem("Usuários", "/admin/usuarios"));
        adminMenu.Add(new MenuItem("Configurações", "/admin/config"));
        mainMenu.Add(adminMenu);

        mainMenu.Render();

        Console.WriteLine($"\nTotal de itens no menu: {mainMenu.CountItems()}");
    }
}