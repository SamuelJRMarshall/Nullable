using System;
namespace Nullable
{
	public class Player
	{
		Defence specialDefence;
		public Player ( Defence defence )
		{
			specialDefence = defence;
		}

		public int Health { get; set; } = 100;

		public void Hit ( int damage ) => Health -= damage - specialDefence.CalculateDamageReduction ( damage );
	}
}
