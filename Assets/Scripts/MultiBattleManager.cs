using UnityEngine;


namespace RPG.Battle.Managers
{
    class MultiBattleManager : BattleManager
    {
        [SerializeField] private BattleCreature[] _allies;
        [SerializeField] private BattleCreature[] _adversaries;
    }
}