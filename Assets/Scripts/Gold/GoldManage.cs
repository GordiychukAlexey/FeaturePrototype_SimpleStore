using Core.Tools;
using UniRx;

namespace Gold
{
	public class GoldManage : Singleton<GoldManage>
	{
		public IReactiveProperty<int> CurrentGoldCount { get; } = new ReactiveProperty<int>(100);
	}
}