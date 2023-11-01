using UnityEngine;
using UnityEngine.UI;
using RPG.Battle;

namespace RPG.UI{
    class LifeBar : MonoBehaviour
    {
        /// <summary>
        /// Amount is a float that goes from 0 to 1
        /// </summary>
        public float FilledAmount{
            set {
                _filledBar.fillAmount = value;
            }
        }

        public IHealth Owner;

        [SerializeField] private Image _filledBar;
        [SerializeField] private Image _barBackground;

        public float MaxHealth{get => Owner.MaxHealth;}
        public float Health{get => Owner.Health;}
    }
}