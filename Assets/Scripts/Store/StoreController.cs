using System;
using System.Linq;
using Core;
using Store.GUI;
using UniRx;

namespace Store
{
	public class StoreController : IDisposable
	{
		private readonly StoreView storeView;
		private readonly StoreBundle[] storeBundles;

		private readonly CompositeDisposable disposables = new();

		public StoreController(
			StoreView storeView,
			StoreBundle[] storeBundles)
		{
			this.storeView = storeView;
			this.storeBundles = storeBundles;

			InitBundles();
		}

		private void InitBundles()
		{
			foreach (StoreBundle storeBundle in storeBundles)
			{
				var newBundleView = storeView.InitNewBundle();
				newBundleView.SetName(storeBundle.BundleName);

				ReactiveProperty<bool> isCanBuyBundle = new(IsCanBuyAll(storeBundle.Spendable));
				foreach (ISpendable spendable in storeBundle.Spendable)
				{
					disposables.Add(spendable.IsCanSpend.Subscribe(b =>
						isCanBuyBundle.Value = b ? IsCanBuyAll(storeBundle.Spendable) : false));
				}

				disposables.Add(isCanBuyBundle.Subscribe(newBundleView.SetCanBuy));

				var storeBundleTmp = storeBundle;
				disposables.Add(newBundleView.OnBuyClick.Subscribe(_ => BuyBundle(storeBundleTmp)));
			}
		}

		private bool IsCanBuyAll(ISpendable[] spendables) => spendables.All(spendable => spendable.IsCanSpend.Value);

		private void BuyBundle(StoreBundle storeBundle)
		{
			foreach (IReward reward in storeBundle.Reward)
			{
				reward.Apply();
			}

			foreach (ISpendable spendable in storeBundle.Spendable)
			{
				spendable.Apply();
			}
		}

		public void Dispose()
		{
			disposables.Dispose();
		}
	}
}