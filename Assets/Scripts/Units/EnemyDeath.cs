using System;
using SoftLogic;
using UnityEngine;
using Zenject;

namespace Units
{
    [RequireComponent(typeof(UnitHealthControl))]
    public class EnemyDeath : MonoBehaviour
    {
        [Inject] private Wallet wallet;
        private UnitHealthControl healthControl;

        private void OnValidate()
        {
            if (healthControl == null)
            {
                healthControl = GetComponent<UnitHealthControl>();
                UnityEditor.Events.UnityEventTools.AddPersistentListener(healthControl.OnKillMe, DropCoin);
            }
            
            
        }

        private void DropCoin()
        {
            
        }
    }
}