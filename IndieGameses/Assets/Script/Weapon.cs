using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading.Tasks;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
           
        }
    }

  

    void Shoot()
    {
        //shooting script
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

       
        //if (bullet != null)
        
            //bullet.transform.position = turret.transform.position;
            //bullet.transform.rotation = turret.transform.rotation;
            //bullet.SetActive(true);
        

    }
}
