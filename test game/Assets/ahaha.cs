using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahaha : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(change());

    }
    public IEnumerator change()
    {
        // wait for 3 seconds
        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}