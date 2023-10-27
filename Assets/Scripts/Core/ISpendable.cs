using UniRx;

namespace Core
{
	public interface ISpendable
	{
		public IReadOnlyReactiveProperty<bool> IsCanSpend { get; }
		public bool Check();
		public void Apply();
	}
}