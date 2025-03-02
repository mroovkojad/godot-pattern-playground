
using System;

public partial class GreenSlimeAIController : Controller
{
    private Random _random;

    public GreenSlimeAIController(Character character): base(character){}


    public override void HandleMovement()
    {
        _moveRightCommand.Execute(_character);
    }
}