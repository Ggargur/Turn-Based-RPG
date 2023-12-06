using System.Collections;
using RPG.Battle;
using UnityEngine;

namespace RPG.UI.Battle
{
    class BattleUiManager : UiManager
    {
        [Header("References")]
        

        [Header("Values")]
        [SerializeField] private float _damageAnimationScaler;

        public void DoVisualDamage(LifeBar bar, float amount){
            StartCoroutine(DoDamageAnimation(bar,amount));
        }

        private IEnumerator DoDamageAnimation(LifeBar bar, float amount)
        {
            float currentHealth = bar.Health;
            float diff = currentHealth - amount;
            float speedScale = amount * _damageAnimationScaler / currentHealth;
            for (float i = currentHealth; i < diff; i += Time.deltaTime * speedScale)
            {
                bar.FilledAmount = i;
                yield return null;
            }
        }
    }

}
