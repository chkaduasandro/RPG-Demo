using UnityEngine;

public static class Constants 
{

	public static class Tags
	{
		public const string Player = "Player";
		public const string Ground = "Ground";
		public const string Interactable = "Interactable";
	}
    
	public static class Animation
	{
		public static class Booleans
		{
			public static readonly int IsIdle = Animator.StringToHash("IsIdle");
			public static readonly int IsMoving = Animator.StringToHash("IsMoving");
			// public static readonly int IsRunning = Animator.StringToHash("IsRunning");
		}

		public static class Floats
		{
			public static readonly string MoveSpeedMultiplier = "MoveSpeedMultiplier";
		}
	}
}