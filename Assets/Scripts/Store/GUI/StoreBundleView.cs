using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Store.GUI
{
	public class StoreBundleView : MonoBehaviour
	{
		[SerializeField] private TMP_Text name;
		[SerializeField] private Button buyButton;

		public void SetName(string s) => name.text = s;

		public IObservable<Unit> OnBuyClick;

		private void Awake()
		{
			OnBuyClick = buyButton.onClick.AsObservable();
		}

		public void SetCanBuy(bool isCanBuy) => buyButton.interactable = isCanBuy;
	}
}