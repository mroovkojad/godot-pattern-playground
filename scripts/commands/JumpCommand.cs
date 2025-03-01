public class JumpCommand : ICommand
{
    public void Execute(Character character)
    {
        if (character.IsOnFloor())
        {
            Vector2 velocity = character.Velocity;
            velocity.Y = Character.JumpVelocity;
            character.Velocity = velocity;
        }
    }
}