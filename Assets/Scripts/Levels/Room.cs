using System;
using System.Collections.Generic;
using Units;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class Room
    {
        public Sprite Background;
        public Sprite Floor;
        public List<EnemyHealthControl> EnemyInRoom;
    }
}