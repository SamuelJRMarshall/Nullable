using System;

namespace Nullable
{
	class Program
	{
		static void Main ( string[ ] args )
		{
			//NullableClass nullableClass = null;

			/////Using the conditional operator
			//int number = nullableClass.Number.HasValue ? nullableClass.Number.Value : -1;

			/////Null-coalescing operator
			//int numberAgain = nullableClass.Number ?? -1;

			/////Null-conditional operator
			//int numberAgainAgain = nullableClass?.Number ?? -1;
			//Console.WriteLine ( numberAgainAgain );

			/////Null-conditional operator continued
			//NullableClass[ ] nullableClasses = {
			//	new NullableClass(1), new NullableClass(null), null
			//};
			//string nC1 = nullableClasses?[ 0 ]?.Number.Value.ToString ( );

			/////Null conditional operator delegate
			////PropertyChangedEventHandler eventHandler = PropertyChanged;
			////if (eventHandler != null){
			////  eventHandler(this, new PropertyChangedEventArgs(...));
			////}

			////PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(...));
			///

			var sam = new Player ( new Defence_IronBones ( ) );
			var lina = new Player ( new Defence_DiamondSkin ( ) );
			var serena = new Player ( Defence.Null );

			sam.Hit ( 5 );
			lina.Hit ( 5 );
			serena.Hit ( 5 );

			Console.WriteLine ( $"{sam.Health} {lina.Health} {serena.Health}" );

		}
	}
}
