using System;
using UnityEngine;


namespace RPG.Battle
{
    [Serializable]
    abstract class Move : ScriptableObject
    {
        public enum Type
        {
            Fire, Water, Grass
        }

        [SerializeField] private Type _type;
        [SerializeField][Range(0, 1)] private float _accuracy;

        public abstract void OnUse(Creature user, Creature target);

    }
}