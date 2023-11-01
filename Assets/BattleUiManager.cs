using System.Collections;
using RPG.Battle;
using UnityEngine;

namespace RPG.UI.Battle
{
    class BattleUiManager : UiManager
    {
        [Header("References")]
        [SerializeField] private LifeBar _allyLifeBar;
        [SerializeField] private LifeBar _enemyLifeBar;

        [Header("Values")]
        [SerializeField] private float _damageAnimationScaler;

        public void DoVisualDamageToAlly(float amount) => DoDamageAnimation(_allyLifeBar, amount);
        public void DoVisualDamageToEnemy(float amount) => DoDamageAnimation(_enemyLifeBar, amount);

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

        public void AssignHealth(IHealth health){
            
        }
    }

}
