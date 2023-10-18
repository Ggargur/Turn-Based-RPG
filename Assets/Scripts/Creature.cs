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

        [SerializeField] private List<Move> _moveset = new List<Move>();

    }
}