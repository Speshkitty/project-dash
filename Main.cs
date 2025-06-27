using Godot;
using System;

public partial class Main : Node
{

    readonly Node enemyToAdd = ResourceLoader.Load<PackedScene>("res://scenes/Characters/enemy/enemy.tscn").Instantiate();

    public override void _Ready()
    {
        AddChild();
        AddChild(); AddChild(); AddChild();
        base._Ready();
    }

    public void AddChild()
    {
        
        AddChild(enemyToAdd);
    }
}
