using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
	public Transform player;
	public Transform bossLeft;
	public Transform bossright;
	public bool isFlipped = false;

    private void Update()
    {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
    public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}
//	leftx = GetComponent<Renderer>().bounds.center;
}
