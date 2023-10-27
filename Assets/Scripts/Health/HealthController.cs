using Core;
using Health.GUI;
using UniRx;

namespace Health
{
	public class HealthController : BaseStatController<HealthView>
	{
		public HealthController(HealthView statView) : base(statView)
		{
			disposables.Add(HealthManage.Instance.CurrentHealthValue.Subscribe(statView.SetHealth));

			disposables.Add(statView.OnPlusClick.Subscribe(unit =>
				HealthManage.Instance.CurrentHealthValue.Value += 10.0f));
		}
	}
}