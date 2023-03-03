using System;
using System.Collections;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace Units
{
    public abstract class UnitHealthControl : MonoBehaviour
    {
        [SerializeField] protected Stats stats;
        [ShowNonSerializedField] private float currentHealth;

        private float CurrentHealth
        {
            get => currentHealth;
            set
            {
                currentHealth = Mathf.Clamp(value, 0, stats.MaxHealth);
                OnChangeHealth?.Invoke(currentHealth);
                if (currentHealth == 0) OnKillMe?.Invoke();
            }
        }

        public UnityEvent<float> OnChangeHealth;
        public UnityEvent<float> OnDamageForMe;
        public UnityEvent OnKillMe;

        private void Start()
        {
            CurrentHealth = stats.MaxHealth;
            StartCoroutine(Regen());
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0)
            {
                throw new Exception("Damage negative.");
            }

            if (Random.Range(0, 1) > stats.DodgeChance)
            {
                damage = 0;
            }

            OnDamageForMe?.Invoke(damage);
            CurrentHealth -= damage;
        }


        private IEnumerator Regen()
        {
            while (currentHealth > 0)
            {
                CurrentHealth += stats.RegenerationHeals;
                yield return new WaitForSecondsRealtime(1);
            }

            yield return null;
        }
    }
}