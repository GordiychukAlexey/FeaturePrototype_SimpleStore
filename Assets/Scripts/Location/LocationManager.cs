using Core.Tools;
using UniRx;

public class LocationManager : Singleton<LocationManager>
{
	public IReactiveProperty<Location.Location> CurrentLocation { get; } =
		new ReactiveProperty<Location.Location>(Location.Location.Location1);
}