using Core;
using UniRx;

namespace Gold
{
	public class GoldSpendable : BaseSpendable<GoldSpendableConfig>
	{
		public GoldSpendable(GoldSpendableConfig config) : base(config)
		{
			disposables.Add(GoldManage.Instance.CurrentGoldCount
				.Select(_ => Check())
				.Subscribe(b => isCanSpend.Value = b));
		}

		public override bool Check() => GoldManage.Instance.CurrentGoldCount.Value >= config.Value;

		public override void Apply() => GoldManage.Instance.CurrentGoldCount.Value -= config.Value;
	}
}