using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public LogicScript logic;
    public bool playerAlive = true;
    public int timer = 0;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && playerAlive)
        {
            shoot();
        }        
    }

    void shoot()
    {
        //shooting logic
        Instantiate(bullet, firePoint.position, firePoint.rotation);

    }

}
