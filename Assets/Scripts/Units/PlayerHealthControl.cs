using Zenject;

namespace Units
{
    public class PlayerHealthControl : UnitHealthControl
    {

        [Inject]
        private void SetStats(Stats stats)
        {
            this.stats = stats;
        }
       
    }
}