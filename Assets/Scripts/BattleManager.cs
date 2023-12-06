using System;
using System.Collections.Generic;
using RPG.UI;
using UnityEngine;


namespace RPG.Battle.Managers
{
    enum Owner
    {
        Ally,
        Adversary
    }

    class BattleManager : MonoBehaviour
    {

        public event Action OnMoveSelection;
        public event Action OnTurnBegin;
        public event Action OnTurnEnd;
        public event Action OnCreatureEntered;
        public event Action OnCreatureLeft;

        [Header("References")]
        [SerializeField] private List<BattleCreature> _ally;
        [SerializeField] private List<BattleCreature> _adversary;

        public void DoDamage()
        {

        }

        
    }

    class BattleCreatureFactory : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private List<Transform> _possibleAllySpots;
        [SerializeField] private List<Transform> _possibleAversarySpots;
        [SerializeField] private GameObject _lifeBarTemplate;

        public void AddCreature(BattleCreature creature, Owner owner)
        {
            SetNewLifeBar(creature);
            
        }

        private void SetNewLifeBar(BattleCreature owner)
        {
            GameObject lifeBarGO = Instantiate(_lifeBarTemplate);
            LifeBar lifeBar = lifeBarGO.GetComponent<LifeBar>();
            lifeBar.Owner = owner;
        }
    }
}