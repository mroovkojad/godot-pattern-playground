
public partial class Game : Node
{
    // private Node _currentScene = null;
    // private PackedScene _mainMenuScene;
    // private PackedScene _levelScene;
//
    // public override void _Ready()
    // {
    //     // Load scene resources
    //     _mainMenuScene = GD.Load<PackedScene>("res://MainMenu.tscn");
    //     _levelScene = GD.Load<PackedScene>("res://Level.tscn");

    //     // Start with the main menu
    //     ChangeSceneTo(_mainMenuScene);
    // }

    // private void ChangeSceneTo(PackedScene sceneResource)
    // {
    //     // Remove current scene if it exists
    //     if (_currentScene != null)
    //     {
    //         RemoveChild(_currentScene);
    //         _currentScene.QueueFree();
    //     }

    //     // Instance the new scene
    //     _currentScene = sceneResource.Instantiate();
    //     AddChild(_currentScene);

    //     // Connect signals if they exist
    //     if (_currentScene is MainMenu mainMenu)
    //     {
    //         mainMenu.StartGame += OnStartGame;
    //     }
    //     else if (_currentScene is Level level)
    //     {
    //         level.ReturnToMenu += OnReturnToMenu;
    //     }
    // }

    // private void OnStartGame()
    // {
    //     ChangeSceneTo(_levelScene);
    // }

    // private void OnReturnToMenu()
    // {
    //     ChangeSceneTo(_mainMenuScene);
    // }
}