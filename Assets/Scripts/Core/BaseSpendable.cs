using System;
using UniRx;

namespace Core
{
	public abstract class BaseSpendable<T> : ISpendable, IDisposable where T : ISpendableConfig
	{
		protected IReactiveProperty<bool> isCanSpend { get; } = new ReactiveProperty<bool>(false);
		public IReadOnlyReactiveProperty<bool> IsCanSpend => isCanSpend;

		protected readonly T config;

		protected readonly CompositeDisposable disposables = new();

		public BaseSpendable(T config)
		{
			this.config = config;
		}

		public abstract bool Check();

		public abstract void Apply();

		public void Dispose()
		{
			disposables.Dispose();
		}
	}
}