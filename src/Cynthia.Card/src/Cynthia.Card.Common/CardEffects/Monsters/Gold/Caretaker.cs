using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("22010")]//看门人
	public class Caretaker : CardEffect
	{//从对方墓场复活1个铜色/银色单位。
		public Caretaker(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}