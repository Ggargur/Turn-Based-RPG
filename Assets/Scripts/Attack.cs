using System;
using UnityEngine;


namespace RPG.Battle
{
    class Attack : Move
    {
        [SerializeField] private float _power;

        public override void OnUse(Creature user, Creature target)
        {
            throw new NotImplementedException();
        }
    }
}