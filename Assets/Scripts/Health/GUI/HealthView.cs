using System;
using Core;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Health.GUI
{
	public class HealthView : BaseStatView
	{
		[SerializeField] private Button plusButton;

		public IObservable<Unit> OnPlusClick;

		private void Awake()
		{
			OnPlusClick = plusButton.onClick.AsObservable();
		}

		public void SetHealth(float value) => StatValueText = value.ToString("0.00");
	}
}