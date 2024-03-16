using UnityEngine;

namespace autohero
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class BulletBase : MonoBehaviour, IMoveable
    {
        public BulletSO bulletSO;
        public int damage; 

      
        public AudioSource shootSound;

        public AudioClip shootSoundClip;
        private void Awake()
        {
            // Инициализация damage в методе Awake, чтобы гарантировать, что bulletSO уже инициализирован
            damage = bulletSO.damage;
            shootSound = GetComponent<AudioSource>();
           shootSound.clip = bulletSO.audioClip;
             
        }
        private void Start()
        {
            shootSound.clip = shootSoundClip;
            Move();
        }

        //public BulletBase()
        //{
        //    this.damage = bulletSO.damage;
        //}
        public  void Move() {
           GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            shootSound.Play();
        }
    }

}
