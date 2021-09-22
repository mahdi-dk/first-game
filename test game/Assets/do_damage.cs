using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class do_damage : MonoBehaviour
{
    public int damage = 40;
    public PhysicsMaterial2D physicsM2d;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        player_health Player = hitInfo.GetComponent<player_health>();
        if (Player != null)
        {
            Player.TakeDamage(damage);
        }


    }

}
