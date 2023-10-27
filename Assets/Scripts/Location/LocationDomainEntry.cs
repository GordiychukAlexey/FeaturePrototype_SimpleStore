using Location.GUI;
using UnityEngine;

namespace Location
{
	public class LocationDomainEntry : MonoBehaviour
	{
		[SerializeField] private LocationView locationView;

		private LocationController locationController;

		private void Start()
		{
			locationController = new LocationController(locationView);
		}

		private void OnDestroy()
		{
			locationController.Dispose();
		}
	}
}