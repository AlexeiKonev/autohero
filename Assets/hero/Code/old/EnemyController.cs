using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace autohero.old
{
    public class EnemyController : MonoBehaviour
    {
        public float speed = 5f;
        public float rotationSpeed = 100f;
        public GameObject bulletPrefab;
        public Transform bulletSpawnPoint;
        public float fireRate = 0.5f;
        private float nextFireTime = 0f;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0, vertical);
            transform.position += movement * speed * Time.deltaTime;

            if (movement != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }

            if (Input.GetButton("Fire1") && Time.time > nextFireTime)
            {
                nextFireTime = Time.time + fireRate;
                Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            }
        }
    }
}
