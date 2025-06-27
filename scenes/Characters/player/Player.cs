using Godot;
using System;

public partial class Player : CharacterBase
{
  [Export]
  public override int Speed { get; set; } = 400;

  public override void _PhysicsProcess(double delta)
  {
	var mousePosition = GetViewport().GetMousePosition();
	Velocity = (mousePosition - GlobalPosition).Normalized() * Speed;

	MoveAndSlide();
  }
}
