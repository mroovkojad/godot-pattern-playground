
using System.Diagnostics.Tracing;

public partial class MainMenu : Control
{
    [Signal]
    public delegate void StartGameEventHandler();

    private Button _startButton;

    public override void _Ready()
    {
        // Get reference to the start button
        _startButton = GetNode<Button>("StartButton");
        _startButton.Pressed += OnStartButtonPressed;
    }

    private void OnStartButtonPressed()
    {
        EmitSignal(SignalName.StartGame);
    }

}
