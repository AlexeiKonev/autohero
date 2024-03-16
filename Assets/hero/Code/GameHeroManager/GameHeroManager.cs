using UnityEngine;

namespace autohero
{
    public class GameHeroManager : MonoBehaviour
    {
        //Singletone Instance
        public static GameHeroManager Instance;



        private void Awake()
        {
            Debug.Log("awake");
            Initialise();

        }

        private void Initialise()
        {
            if (Instance == null) { Instance = this; } else { Destroy(Instance); }



        }

    }

    public interface IShootable
    {
        void Shoot(Transform gunPosition);
    }

    public abstract class GunBase : IShootable
    {
        public void Shoot(Transform gunPosition)
        {
            throw new System.NotImplementedException();
        }
    }

}
