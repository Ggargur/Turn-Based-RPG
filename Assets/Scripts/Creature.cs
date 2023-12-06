using System.Collections.Generic;
using UnityEngine;

namespace RPG.Battle
{
    [CreateAssetMenu()]
    [System.Serializable]
    class Creature : ScriptableObject
    {
        [SerializeField] private int _health;
        [SerializeField] private int _attack;
        [SerializeField] private int _defence;
        [SerializeField] private int _speed;

        [SerializeField] private List<Move> _learnableMoves = new();

    }

    class CreatureAttribute
    {
        enum Type
        {
            Health, Attack, Defence, Speed
        }

        private int _value;
        private int _effordValue;
        private int _individualValue;

        public CreatureAttribute(int individualValue, int effordValue, int value)
        {
            _individualValue = individualValue;
            _effordValue = effordValue;
            _value = value;
        }
    }
}