using Godot;

public partial class Player : CharacterBody2D
{
	private const float Speed = 200f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed;
		MoveAndSlide();
	}
}
