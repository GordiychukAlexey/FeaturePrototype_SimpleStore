using System;
using Core;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Gold.GUI
{
	public class GoldView : BaseStatView
	{
		[SerializeField] private Button plusButton;

		public IObservable<Unit> OnPlusClick;

		private void Awake()
		{
			OnPlusClick = plusButton.onClick.AsObservable();
		}

		public void SetGold(int count) => StatValueText = count.ToString();
	}
}