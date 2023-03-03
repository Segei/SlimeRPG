using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class LevelsFactory : ScriptableObject
    {
        public Level CurrentLevel;
        [SerializeField] private List<Level> levels = new List<Level>();
    }
}