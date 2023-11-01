using UnityEngine;


namespace RPG.Battle
{
    public partial class BattleCreature : MonoBehaviour, IHealth
    {
        [Header("References")]
        [SerializeField] private Creature _creature;

        [Header("Values")]
        [SerializeField] private float _health;
        [SerializeField] private float _maxHealth;

        public float Health { get => _health; set => _health = value; }
        public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void SelectMove()
        {

        }
    }
}