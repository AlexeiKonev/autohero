using System;
using UnityEngine;

namespace autohero
{
    public class GameHeroManager : MonoBehaviour
    {
        //Singletone Instance
        public static GameHeroManager Instance;

        private IShootable playerGun;

        [SerializeField]  private  Transform playerGunPos;

        [SerializeField] BulletBase playerBullet;

        public   event Action  act ;
         
        private void Awake()
        {
            Debug.Log("awake");
            Initialise();
            playerBullet = new BulletSimple();
            playerGun = new SingleShootGun(playerBullet);

             
        }

        //метод под кнопку
        public void Shoot()
        {
            playerGun.Shoot(playerGunPos);
        }

        //internal void Instantiatex(BulletBase bullet, Transform gunPosition)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Instantiatex(Object obj, Transform transform)
        //{
        //    Instantiate(obj, transform);

        //}

        private void Initialise()
        {
            if (Instance == null) { Instance = this; } else { Destroy(Instance); }



        }

    }

}
