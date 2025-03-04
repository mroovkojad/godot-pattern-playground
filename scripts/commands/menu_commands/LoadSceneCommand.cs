using System;

public partial class LoadSceneCommand : Node, ICommand<string>
{
    public void Execute(string scenePath)
    {
        Error result = GetTree().ChangeSceneToFile(scenePath);
        if (result != Error.Ok)
        {
            GD.PrintErr($"Failed to load scene: {scenePath}. Error code: {result}");
        }

    }
}