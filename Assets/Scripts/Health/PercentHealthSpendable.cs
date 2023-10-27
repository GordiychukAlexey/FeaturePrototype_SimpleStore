using Core;
using UniRx;

namespace Health
{
	public class PercentHealthSpendable : BaseSpendable<PercentHealthSpendableConfig>
	{
		public PercentHealthSpendable(PercentHealthSpendableConfig config) : base(config)
		{
			disposables.Add(HealthManage.Instance.CurrentHealthValue
				.Select(_ => Check())
				.Subscribe(b => isCanSpend.Value = b));
		}

		public override bool Check() => HealthManage.Instance.CurrentHealthValue.Value >= config.Value;

		public override void Apply() => HealthManage.Instance.CurrentHealthValue.Value *= 1.0f - config.Value / 100.0f;
	}
}