using UnityEngine;

namespace autohero
{
    public abstract class GunBase : MonoBehaviour, IShootable,IReloadable
    {
       public BulletBase bullet;
        public GunBase (BulletBase bullet)
        {
            this.bullet = bullet;
        }
        public virtual void Reload()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Shoot(Transform gunPosition)
        {
            throw new System.NotImplementedException();
        }
    }

}
