using System;
using UnityEngine;

namespace Units
{
    [CreateAssetMenu(menuName = "GameLogic/LevelUp", fileName = "LevelUpBuffs")]
    public class LevelUp : ScriptableObject
    {
        public InfoLevel Health;
        public InfoLevel Regen;
        public InfoLevel Damage;
        public InfoLevel APM;
        public InfoLevel Dodge;
        public InfoLevel Crit;

        [Serializable]
        public class InfoLevel
        {
            public int Level;
            public int MaxLevel;
            public float LevelUpBuf;
        }
    }
}