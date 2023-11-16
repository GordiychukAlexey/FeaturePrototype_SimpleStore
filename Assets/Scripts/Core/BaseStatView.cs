using TMPro;
using UnityEngine;

namespace Core{
	public abstract class BaseStatView : MonoBehaviour{
		[SerializeField] private TMP_Text statValueText;

		protected string StatValueText{
			get => statValueText.text;
			set => statValueText.text = value;
		}
	}
}