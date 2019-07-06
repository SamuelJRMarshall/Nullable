using System;
namespace Nullable
{
	public class Defence_IronBones : Defence
	{
		public override int CalculateDamageReduction ( int totalDamage )
		{
			return 1;
		}
	}
}
