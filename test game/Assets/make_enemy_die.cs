using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_enemy_die : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(change());

    }
    public IEnumerator change()
    {
        // wait for 3 seconds
        yield return new WaitForSeconds(1.5f);

        Destroy(gameObject);
    }
}