using System.Collections.Generic;
using UnityEngine;

namespace RPG.Battle
{
    class Party : MonoBehaviour
    {
        public List<Creature> Members { get => _members; set => _members = value; }
        [SerializeField] private List<Creature> _members = new();
    }
}
