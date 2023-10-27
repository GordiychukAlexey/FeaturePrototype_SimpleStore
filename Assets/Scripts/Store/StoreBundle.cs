using System.Linq;
using Core;

namespace Store
{
	public class StoreBundle
	{
		public string BundleName { get; }

		public IReward[] Reward { get; }

		public ISpendable[] Spendable { get; }

		public StoreBundle(StoreBundleConfig storeBundleConfig)
		{
			BundleName = storeBundleConfig.BundleName;
			Reward = storeBundleConfig.Reward.ToArray();
			Spendable = storeBundleConfig.Spendable.Select(config => config.CreateInstance()).ToArray();
		}
	}
}