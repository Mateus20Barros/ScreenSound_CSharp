
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSairApp : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Environment.Exit(0);
    }
}
