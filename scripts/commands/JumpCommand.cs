public class JumpCommand : ICommand
{
    public void Execute(Character character)
    {
        if (character.IsOnFloor())
        {
            Vector2 velocity = character.Velocity;
            velocity.Y = character.JumpVelocity;
            character.Velocity = velocity;
        }
    }
}