using Core.Tools;
using UniRx;

namespace Health
{
	public class HealthManage : Singleton<HealthManage>
	{
		public IReactiveProperty<float> CurrentHealthValue { get; } = new ReactiveProperty<float>(100.0f);
	}
}