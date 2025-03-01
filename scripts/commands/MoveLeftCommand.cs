public class MoveLeftCommand : ICommand
{
    public void Execute(Character character)
    {
        Vector2 velocity = character.Velocity;
        velocity.X = -Character.Speed;
        character.Velocity = velocity;
    }
}