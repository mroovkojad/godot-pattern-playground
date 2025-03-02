public abstract partial class Character : CharacterBody2D
{
    public float Speed { get; protected set; }
    public float JumpVelocity { get; protected set; }
    protected Controller _controller;

    protected Character()
    {
        // Set instance values from class defaults
        Speed = 200.0f;
        JumpVelocity = -300.0f;
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