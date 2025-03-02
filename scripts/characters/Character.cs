public abstract partial class Character : CharacterBody2D
{
    public static float DefaultSpeed {get; protected set;} = 200.0f;
    public static float DefaultJumpVelocity {get; protected set;} = -300.0f;

    // Instance properties
    public virtual float Speed { get; protected set; }
    public virtual float JumpVelocity { get; protected set; }
    public AnimatedSprite2D AnimatedSprite { get; set; }
    protected Controller _controller;


    public override void _Ready()
    {
        base._Ready();
        Speed = DefaultSpeed;
        JumpVelocity = DefaultJumpVelocity;
        AnimatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
    }
    public override void _PhysicsProcess(double delta)
    {
        // Apply gravity
        if (!IsOnFloor())
        {
            Vector2 velocity = Velocity;
            velocity += GetGravity() * (float)delta;
            Velocity = velocity;
        }

        // Handle input through the controller
        _controller.HandleMovement();

        // Apply movement
        MoveAndSlide();
    }
}