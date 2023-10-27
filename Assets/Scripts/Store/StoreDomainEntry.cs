using System.Collections.Generic;
using System.Linq;
using Store.GUI;
using UnityEngine;

namespace Store
{
	public class StoreDomainEntry : MonoBehaviour
	{
		[SerializeField] private List<StoreBundleConfig> storeBundleConfigs;
		[SerializeField] private StoreView storeView;

		private StoreController storeController;

		private void Awake()
		{
			var storeBundles = storeBundleConfigs.Select(config => new StoreBundle(config)).ToArray();

			storeController = new StoreController(storeView, storeBundles);
		}

		private void OnDestroy()
		{
			storeController.Dispose();
		}
	}
}