public partial class PurpleSlime : Character
{
    public new static float DefaultSpeed {get; protected set;} = 100.0f;
    public new static float DefaultJumpVelocity {get; protected set;} = -100.0f;
    protected override float GetClassDefaultSpeed() => DefaultSpeed;
    protected override float GetDefaultJumpVelocity() => DefaultJumpVelocity;
    public override void _Ready()
    {
        base._Ready();
        _controller = new PurpleSlimeAIController(this);
    }
}