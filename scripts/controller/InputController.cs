public partial class InputController : Controller
{
    public InputController(Character character): base(character){}

    public override void HandleMovement()
    {
        // Handle jump input
        if (Input.IsActionJustPressed("ui_up"))
        {
            _jumpCommand.Execute(_character);
        }

        // Handle movement input
        Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        if (direction.X < 0)
        {
            _moveLeftCommand.Execute(_character);
            GD.Print($"Player Speed: {_character.Speed}");
        }
        else if (direction.X > 0)
        {
            _moveRightCommand.Execute(_character);
        }
        else
        {
            _stopCommand.Execute(_character);
        }
    }
}
