using Gold.GUI;
using UnityEngine;

namespace Gold
{
	public class GoldDomainEntry : MonoBehaviour
	{
		[SerializeField] private GoldView goldView;

		private GoldController goldController;

		private void Start()
		{
			goldController = new GoldController(goldView);
		}

		private void OnDestroy()
		{
			goldController.Dispose();
		}
	}
}