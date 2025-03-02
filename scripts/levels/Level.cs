public partial class Level : Node
{
    [Signal]
    public delegate void ReturnToMenuEventHandler();

    private Button _returnToMenuButton;

    public override void _Ready()
    {
        // Get reference to the return button in pause menu
        _returnToMenuButton = GetNode<Button>("PauseMenu/ReturnToMenuButton");
        _returnToMenuButton.Pressed += OnReturnToMenuButtonPressed;
    }

    private void OnReturnToMenuButtonPressed()
    {
        EmitSignal(SignalName.ReturnToMenu);
    }
}