using UnityEngine;

namespace autohero
{
    public abstract class BulletBase : MonoBehaviour, IMoveable
    {
        public BulletSO bulletSO;
        public int damage;
        private void Awake()
        {
            // Инициализация damage в методе Awake, чтобы гарантировать, что bulletSO уже инициализирован
            this.damage = bulletSO.damage;
        }

        //public BulletBase()
        //{
        //    this.damage = bulletSO.damage;
        //}
        public virtual void Move() { }
    }

}
