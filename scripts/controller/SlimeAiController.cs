
using System;

public partial class SlimeAIController : Controller
{
    private Random _random;

    public SlimeAIController(Character character): base(character){}


    public override void HandleMovement()
    {
        _moveLeftCommand.Execute(_character);
    }
}