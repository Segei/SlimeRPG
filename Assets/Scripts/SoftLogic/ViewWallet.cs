using System;
using UnityEngine;
using Zenject;

namespace SoftLogic
{
    public class ViewWallet : MonoBehaviour
    {
        [Inject] private Wallet wallet;
        [SerializeField] private ViewCoin prefabViewCoin;
        [SerializeField] private RectTransform PositionSpawn;

        private void Start()
        {
            wallet.OnChangeCoin.AddListener(SpawnViewCoin);
        }

        private void SpawnViewCoin(bool positive, int count)
        {
            ViewCoin instance = Instantiate(prefabViewCoin);
            instance.SetValue(positive, count);
            instance.transform.position = PositionSpawn.transform.position;
        }
        
        
        
    }
}