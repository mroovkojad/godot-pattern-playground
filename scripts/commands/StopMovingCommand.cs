public class StopCommand : ICommand
{
    public void Execute(Character character)
    {
        Vector2 velocity = character.Velocity;
        velocity.X = 0;
        character.Velocity = velocity;
    }
}
