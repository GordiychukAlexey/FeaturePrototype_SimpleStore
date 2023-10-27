using System.Collections.Generic;
using Core;
using UnityEngine;

namespace Store
{
	[CreateAssetMenu(fileName = "StoreBundleConfig", menuName = "Store/StoreBundleConfig", order = 0)]
	public class StoreBundleConfig : ScriptableObject
	{
		[SerializeField] private string bundleName;

		[SerializeReference, SelectImplementation(typeof(IReward))]
		private List<IReward> reward = new();

		[SerializeReference, SelectImplementation(typeof(ISpendableConfig))]
		private List<ISpendableConfig> spendable = new();


		public string BundleName => bundleName;

		public List<IReward> Reward => reward;

		public List<ISpendableConfig> Spendable => spendable;
	}
}