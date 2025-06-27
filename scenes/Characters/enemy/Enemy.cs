using Godot;
using System;

public partial class Enemy : CharacterBase
{
	public override void _PhysicsProcess(double delta)
	{
		
		var target = GetParent().GetNode<CharacterBase>("Player").GlobalPosition; //This needs to be the player character
		Velocity = (target - GlobalPosition).Normalized() * Speed;

		MoveAndSlide();
	}
}
