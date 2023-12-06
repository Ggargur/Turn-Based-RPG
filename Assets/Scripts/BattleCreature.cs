using System.Collections.Generic;
using RPG.UI;
using UnityEngine;


namespace RPG.Battle
{
    class BattleCreature : MonoBehaviour, IHealth
    {
        [Header("References")]
        [SerializeField] private Creature _creature;
        [SerializeField] private LifeBar _lifebar;

        [Header("Values")]
        [SerializeField] private float _health;
        [SerializeField] private float _maxHealth;

        public float Health
        {
            get => _health; set
            {
                _health = value;
            }
        }
        public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public LifeBar Lifebar { get => _lifebar; set => _lifebar = value; }
        public List<Move> Moves { get => _moves; set => _moves = value; }

        private List<Move> _moves = new();
        //private Player _owner;

        public void TakeDamage()
        {
            Health -= 10;
            print("Took damage");
        }

        private void Update()
        {
#if UNITY_EDITOR
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage();
            }
#endif
        }
    }
}