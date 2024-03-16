using UnityEngine;

namespace autohero
{
    public class SingleShootGun  : GunBase
    {
        public SingleShootGun(BulletBase bullet) : base(bullet)
        {
            bullet = new BulletSimple();
        }

        public override void Shoot(Transform gunPosition)
        {
            
            Debug.Log("Single shoot");
        }
    }

}
