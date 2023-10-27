using Core;
using UniRx;

namespace Location
{
	public class LocationSpendable : BaseSpendable<LocationSpendableConfig>
	{
		public LocationSpendable(LocationSpendableConfig config) : base(config)
		{
			disposables.Add(LocationManager.Instance.CurrentLocation
				.Select(_ => Check())
				.Subscribe(b => isCanSpend.Value = b));
		}

		public override bool Check() => true;

		public override void Apply() => LocationManager.Instance.CurrentLocation.Value = config.Value;
	}
}