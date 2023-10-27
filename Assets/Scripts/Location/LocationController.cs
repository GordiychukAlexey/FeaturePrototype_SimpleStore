using Core;
using Location.GUI;
using UniRx;

namespace Location
{
	public class LocationController : BaseStatController<LocationView>
	{
		public LocationController(LocationView statView) : base(statView)
		{
			disposables.Add(LocationManager.Instance.CurrentLocation.Subscribe(statView.SetLocation));
		}
	}
}