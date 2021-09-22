using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            animator.SetBool("fire", true);
        }
        else if(Input.GetButtonUp("Fire1")){
            animator.SetBool("fire", false);
        }
    }
 
    void Shoot(){
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
