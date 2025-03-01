using Godot;
using System;

public partial class Player : Character
{
	public override void _Ready(){
		_controller = new InputController(this);
	}

}
