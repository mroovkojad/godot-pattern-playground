public abstract partial class Character : CharacterBody2D
{
    public const float Speed = 200.0f;
    public const float JumpVelocity = -300.0f;

    protected Controller _controller;

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