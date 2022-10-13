using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefab;
    public Animator shooting;
    
    void Update()
    {
        shooting.SetBool("IsShooting",false);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            shooting.SetBool("IsShooting",true);
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}
