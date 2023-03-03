using UnityEngine;

namespace Units
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Stats", menuName = "GameLogic/Stats")]
    public class Stats : ScriptableObject
    {
        [Range(0, 1), SerializeField] private float dodgeChance;
        [Range(0, 1), SerializeField] private float criticalChance;
        public float MaxHealth;
        public float RegenerationHeals;
        public float Damage;
        public float CountAttackPerMinute;
        public int MaximumCountCoin;
        public float DodgeChance
        {
            get => dodgeChance;
            set { dodgeChance = Mathf.Clamp(value, 0, 1); }
        }

        public float CriticalChance
        {
            get => criticalChance;
            set { criticalChance = Mathf.Clamp(value, 0, 1); }
        }
    }
}