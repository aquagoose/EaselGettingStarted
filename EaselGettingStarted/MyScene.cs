using Easel.GUI;
using Easel.Scenes;

namespace EaselGettingStarted;

public class MyScene : Scene
{
    protected override void Initialize()
    {
        base.Initialize();
        
        UI.Add("hello", new Label(new Position(Anchor.CenterCenter), "Hello world!", 50, null));
    }
}