
using System;

public partial class PurpleSlimeAIController : Controller
{
    private Random _random;

    public PurpleSlimeAIController(Character character): base(character){}


    public override void HandleMovement()
    {
        _moveLeftCommand.Execute(_character);
    }
}