using System;
using Core;

namespace Location.GUI
{
	public class LocationView : BaseStatView
	{
		public void SetLocation(Location location) => StatValueText = Enum.GetName(typeof(Location), location);
	}
}