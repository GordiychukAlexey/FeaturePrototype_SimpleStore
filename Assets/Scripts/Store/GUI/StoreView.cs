using UnityEngine;

namespace Store.GUI
{
	public class StoreView : MonoBehaviour
	{
		[SerializeField] private RectTransform storeBundlesRoot;
		[SerializeField] private StoreBundleView storeBundlePrefab;

		public StoreBundleView InitNewBundle() => Instantiate(storeBundlePrefab, storeBundlesRoot);
	}
}