using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.
using System.Collections.Generic;

namespace autohero
{
    public class GameHeroManager : MonoBehaviour
    {
        [SerializeField] private Dropdown bulletDropdown;

        //Singletone Instance
        public static GameHeroManager Instance;

        private IShootable playerGun;

        [SerializeField]  private  Transform playerGunPos;

        [SerializeField] BulletBase playerBullet1;
        [SerializeField] BulletBase playerBullet2;
        [SerializeField] List<BulletBase> playerBulletList;

       
        private void Awake()
        {
            Debug.Log("awake");
            Initialise();
            //playerBullet = new BulletSimple();
            playerBulletList.Add(playerBullet1);
            playerBulletList.Add(playerBullet2);

            playerGun = new SingleShootGun(playerBulletList[bulletDropdown.value]);
        }

        public void SelectBullet()
        {
            

            if (bulletDropdown.value == 0)
            {
                playerGun = new SingleShootGun(playerBulletList[bulletDropdown.value]);
                Debug.Log($"{playerBulletList[bulletDropdown.value].gameObject.name} choosed");
            }
            if (bulletDropdown.value == 1)
            {
                playerGun = new SingleShootGun(playerBulletList[bulletDropdown.value]);
                Debug.Log($"{playerBulletList[bulletDropdown.value].gameObject.name} choosed");
            }
        }
        private void Update()
        {
            
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

