using DefaultNamespace;
using SoftLogic;
using Units;
using UnityEngine;
using Zenject;

namespace Injects
{
    [CreateAssetMenu(fileName = "MainGameLinks", menuName = "Installers/MainGameLinks")]
    public class MainGameLinks : ScriptableObjectInstaller<MainGameLinks>
    {
        [SerializeField] private Wallet wallet;
        [SerializeField] private Stats playerStats;
        [SerializeField] private LevelUp levelUpPlayer;
        [SerializeField] private LevelsFactory factory;
        public override void InstallBindings()
        {
            Container.Bind<Wallet>().FromInstance(wallet).AsSingle().NonLazy();
            Container.Bind<Stats>().FromInstance(playerStats).AsSingle().NonLazy();
            Container.Bind<LevelUp>().FromInstance(levelUpPlayer).AsSingle().NonLazy();
            Container.Bind<LevelsFactory>().FromInstance(factory).AsSingle().NonLazy();
        }
    }
}