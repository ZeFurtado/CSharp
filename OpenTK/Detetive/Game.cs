using OpenTK.Windowing.Desktop;

namespace Detetive;

public class Game : GameWindow
{
    public Game(int width, int height, string title) : base (GameWindowSettings.Default, new NativeWindowSettings() { ClientSize = (width, height), Title = title})
    { 

    }
}
