public class MoveLeftCommand : ICommand<Character>
{
    public void Execute(Character character)
    {
        Vector2 velocity = character.Velocity;
        velocity.X = -character.Speed;
        character.Velocity = velocity;
    }
}