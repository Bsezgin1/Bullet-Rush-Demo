using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;

    [SerializeField]private float timeBetweenFires =0.1f;
    [SerializeField]private float timeSinceLastFire = Mathf.Infinity;



    [SerializeField] public Vision vision;




    private void Update() 
    {
        timeSinceLastFire += Time.deltaTime;

        if(vision.inRange)
        {
            Fire();
        }

    }

    private void Fire()
    {
        if(timeSinceLastFire >= timeBetweenFires)
        {
            timeSinceLastFire =0;

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
        
    }
}
