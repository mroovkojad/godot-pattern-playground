using System;

public class MoveRightCommand : ICommand
{
    public void Execute(Character character)
    {
        Vector2 velocity = character.Velocity;
        velocity.X = character.Speed;
        character.Velocity = velocity;
    }
}