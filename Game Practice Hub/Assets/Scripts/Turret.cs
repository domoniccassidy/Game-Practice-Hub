using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float reloadTime;
    [SerializeField] Transform bulletStart;
    [SerializeField] float bulletSpeed;
    float timeLeftToShoot = 0;
    
    // Update is called once per frame
    void Update()
    {
        float turretPos = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, turretPos));

        if (Input.GetMouseButton(0) && timeLeftToShoot <= 0)
        {
            Fire();
           timeLeftToShoot= reloadTime;
        }
        if(timeLeftToShoot !> 0)
        {
            timeLeftToShoot -= Time.deltaTime;
        }
        
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletStart.parent.GetComponent<Collider>());
        bullet.transform.position = bulletStart.position;
        bullet.GetComponent<Rigidbody>().AddForce(bulletStart.forward * bulletSpeed, ForceMode.Impulse);

        


    }
}
