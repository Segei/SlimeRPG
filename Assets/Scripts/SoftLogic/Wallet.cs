using System;
using UnityEngine.Events;

namespace SoftLogic
{
    [Serializable]
    public class Wallet
    {
        public int CoinValue { get; private set; }

        public UnityEvent<bool, int> OnChangeCoin;

        public bool TryGetCoin(int count)
        {
            if (count < 0)
            {
                return false;
            }
            
            if (CoinValue > count)
            {
                CoinValue -= count;
                OnChangeCoin?.Invoke(false, count);
                return true;
            }

            return false;
        }

        public void AddCoin(int count)
        {
            if (count < 0)
            {
                return;
            }

            CoinValue += count;
            OnChangeCoin?.Invoke(true, count);
        }
    }
}