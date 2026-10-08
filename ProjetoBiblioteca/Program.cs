using System.ComponentModel.Design;
using ProjetoBiblioteca.UI;
namespace ProjetoBiblioteca
{
    class Program
    {
        static void Main(string[]args)
        {
            MenuCommand menu = new Menu();
            menu.ExibirMenu();
        }
    }
}
