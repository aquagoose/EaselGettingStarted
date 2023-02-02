using Easel;
using EaselGettingStarted;

GameSettings settings = new GameSettings();

using EaselGame game = new EaselGame(settings, new MyScene());
game.Run();