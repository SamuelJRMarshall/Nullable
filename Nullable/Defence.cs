namespace Nullable
{
	public abstract class Defence
	{
		public abstract int CalculateDamageReduction ( int totalDamage );

		public static Defence Null { get; } = new Defence_Null ( );

		private class Defence_Null : Defence
		{
			public override int CalculateDamageReduction ( int totalDamage )
			{
				return 0;
			}
		}
	}
}
