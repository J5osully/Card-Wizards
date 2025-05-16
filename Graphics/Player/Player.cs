using Godot;
using System;

public partial class Player : Sprite2D
{
	public override void _Ready()
	{
		SetProcess(true); // Optional in Godot 4, but okay to keep
	}

	public override void _Process(double delta)
	{
		float AMOUNT = 5;

		if (Input.IsKeyPressed(Key.W))
			Position += new Vector2(0, -AMOUNT);

		if (Input.IsKeyPressed(Key.A))
			Position += new Vector2(-AMOUNT, 0);

		if (Input.IsKeyPressed(Key.S))
			Position += new Vector2(0, AMOUNT);

		if (Input.IsKeyPressed(Key.D))
			Position += new Vector2(AMOUNT, 0);
	}
}
