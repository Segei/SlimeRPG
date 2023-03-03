using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Level : ScriptableObject
    {
        [SerializeField] private float EnemyStatsMultiple;
        [SerializeField] private float MoneyMultiple;
        [SerializeField] private List<Room> rooms;
    }
}