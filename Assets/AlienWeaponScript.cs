using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWeaponScript : MonoBehaviour
{

    public GameObject alienBullet;
    public bool canShoot = true;
    public Transform firePoint;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void shoot()
    {
        Instantiate(alienBullet, firePoint.position, firePoint.rotation);

    }
   
}
