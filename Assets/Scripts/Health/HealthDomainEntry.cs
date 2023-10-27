using Health.GUI;
using UnityEngine;

namespace Health
{
	public class HealthDomainEntry : MonoBehaviour
	{
		[SerializeField] private HealthView healthView;

		private HealthController healthController;

		private void Start()
		{
			healthController = new HealthController(healthView);
		}

		private void OnDestroy()
		{
			healthController.Dispose();
		}
	}
}