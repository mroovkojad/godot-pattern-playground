using Godot;
using System;

public partial class SceneManager : Node
{
    // Scene paths as constants or configurable in inspector
    [Export]
    public string MainMenuScenePath { get; set; } = "res://scenes/MainMenu.tscn";
    
    [Export]
    public string LevelScenePath { get; set; } = "res://scenes/Level.tscn";

    // Current active scene reference
    private Node _currentScene;

    // Cached scene instances to avoid full reloading
    private Node _mainMenuScene;
    private Node _levelScene;

    public override void _Ready()
    {
        // Ensure only one SceneManager exists
        if (GetTree().GetNodesInGroup("SceneManager").Count > 1)
        {
            QueueFree();
            return;
        }

        // Add this to a group for easy reference
        AddToGroup("SceneManager");
    }

    // Method to change scenes with optional caching
    public void ChangeScene(SceneType sceneType, bool useCache = true)
    {
        // Remove current scene
        if (_currentScene != null)
        {
            _currentScene.QueueFree();
        }

        // Determine which scene to load
        switch (sceneType)
        {
            case SceneType.MainMenu:
                _currentScene = LoadOrCreateScene(ref _mainMenuScene, MainMenuScenePath, useCache);
                break;
            case SceneType.Level:
                _currentScene = LoadOrCreateScene(ref _levelScene, LevelScenePath, useCache);
                break;
        }

        // Add the new scene to the scene tree
        GetTree().Root.AddChild(_currentScene);
    }

    // Helper method to load or create scene instances
    private Node LoadOrCreateScene(ref Node cachedScene, string scenePath, bool useCache)
    {
        if (useCache && cachedScene != null)
        {
            return cachedScene;
        }

        var scene = GD.Load<PackedScene>(scenePath);
        var instance = scene.Instantiate();

        // Cache the scene if requested
        if (useCache)
        {
            cachedScene = instance;
        }

        return instance;
    }

    // Enum to clearly define scene types
    public enum SceneType
    {
        MainMenu,
        Level
    }

    // Method to pass data between scenes
    public void TransitionWithData(SceneType sceneType, object transitionData)
    {
        // Load the scene
        ChangeScene(sceneType);

        // If the new scene implements a data receive interface
        if (_currentScene is ISceneDataReceiver dataReceiver)
        {
            dataReceiver.ReceiveSceneData(transitionData);
        }
    }
}

// Interface for scenes that can receive transition data
public interface ISceneDataReceiver
{
    void ReceiveSceneData(object data);
}

// Example implementation in scenes
public partial class MainMenu : Node, ISceneDataReceiver
{
    public void ReceiveSceneData(object data)
    {
        // Handle any data passed from previous scene
        GD.Print($"Received data in Main Menu: {data}");
    }
}

public partial class Level : Node, ISceneDataReceiver
{
    public void ReceiveSceneData(object data)
    {
        // Handle any data passed from previous scene
        GD.Print($"Received data in Level: {data}");
    }
}

// Example usage in another script
public partial class GameController : Node
{
    private SceneManager _sceneManager;

    public override void _Ready()
    {
        // Get the SceneManager (assuming it's an autoload)
        _sceneManager = GetNode<SceneManager>("/root/SceneManager");
    }

    public void StartGame()
    {
        // Change to level scene
        _sceneManager.ChangeScene(SceneManager.SceneType.Level);
    }

    public void ReturnToMainMenu()
    {
        // Return to main menu
        _sceneManager.ChangeScene(SceneManager.SceneType.MainMenu);
    }
}
