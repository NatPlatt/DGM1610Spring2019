using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;

        public Stuff(int bul)
        {
            bullets = bul;
        }
    }
    public Stuff myStuff = new Stuff(10);
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    private
   

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    private Rigidbody Instantiate(Rigidbody original, Vector3 firePositionPosition)
    {
        throw new System.NotImplementedException();
    }
}
