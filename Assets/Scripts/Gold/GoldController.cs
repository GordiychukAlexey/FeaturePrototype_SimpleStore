using Core;
using Gold.GUI;
using UniRx;

namespace Gold
{
	public class GoldController : BaseStatController<GoldView>
	{
		public GoldController(GoldView statView) : base(statView)
		{
			disposables.Add(GoldManage.Instance.CurrentGoldCount.Subscribe(statView.SetGold));

			disposables.Add(statView.OnPlusClick.Subscribe(unit =>
				GoldManage.Instance.CurrentGoldCount.Value += 10));
		}
	}
}