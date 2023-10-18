using System;
using UnityEngine;


namespace RPG.Battle.Managers
{
    class BattleManager : MonoBehaviour
    {

        public event Action OnMoveSelection;
        public event Action OnTurnBegin;
        public event Action OnTurnEnd;
        public event Action OnCreatureEntered;
        public event Action OnCreatureLeft;

        [SerializeField] private BattleCreature _ally;
        [SerializeField] private BattleCreature _adversary;

    }
}