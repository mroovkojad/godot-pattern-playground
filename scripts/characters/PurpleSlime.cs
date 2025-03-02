public partial class PurpleSlime : Character
{

    public new static float DefaultSpeed {get; protected set;} = 50.0f;

    public override void _Ready()
    {
        base._Ready();
        Speed = 100;
        JumpVelocity = -200;
        _controller = new PurpleSlimeAIController(this);
    }
}