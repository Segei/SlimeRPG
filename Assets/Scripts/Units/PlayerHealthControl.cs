using System;
using NaughtyAttributes;
using UnityEngine;
using Zenject;

namespace Units
{
    public class PlayerHealthControll : MonoBehaviour
    {
       [Inject, ShowNonSerializedField] private Stats stats;
       [ShowNonSerializedField] private float currentHealth;

       private void Start()
       {
           currentHealth = stats.MaxHealth;
       }
    }
}