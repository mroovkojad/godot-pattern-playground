public abstract partial class Controller : Node2D
{
    protected readonly ICommand _moveLeftCommand;
    protected readonly ICommand _moveRightCommand;
    protected readonly ICommand _jumpCommand;
    protected readonly ICommand _stopCommand;
    protected readonly Character _character;

    public Controller(Character character)
    {
        _character = character;
        _moveLeftCommand = new MoveLeftCommand();
        _moveRightCommand = new MoveRightCommand();
        _jumpCommand = new JumpCommand();
        _stopCommand = new StopCommand();
    }

    public abstract void HandleMovement();

}
