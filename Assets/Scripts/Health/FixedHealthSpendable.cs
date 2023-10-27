using Core;
using UniRx;

namespace Health
{
	public class FixedHealthSpendable : BaseSpendable<FixedHealthSpendableConfig>
	{
		public FixedHealthSpendable(FixedHealthSpendableConfig config) : base(config)
		{
			disposables.Add(HealthManage.Instance.CurrentHealthValue
				.Select(_ => Check())
				.Subscribe(b => isCanSpend.Value = b));
		}

		public override bool Check() => HealthManage.Instance.CurrentHealthValue.Value >= config.Value;

		public override void Apply() => HealthManage.Instance.CurrentHealthValue.Value -= config.Value;
	}
}