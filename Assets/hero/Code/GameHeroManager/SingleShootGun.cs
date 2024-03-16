using UnityEngine;

namespace autohero
{
    public class SingleShootGun  : GunBase
    {
        public SingleShootGun(BulletBase bullet) : base(bullet)
        {
            this.bullet = bullet;
        }

        public override void Shoot(Transform gunPosition)
        {
            Instantiate(bullet, gunPosition.position, bullet.transform.rotation);

            Debug.Log($"{bullet.gameObject.name} Single shoot");
        }
    }

}
