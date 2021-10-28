using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Cinemachine;

public class respawn_manager : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPrefab;
    public Transform respawnpoint;
    bool playerDead = false;
    public CinemachineVirtualCamera playerCam;//player cam
    public int spawnDelay = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");

        if (player != null)
        {

        }
        else 
        {
            playerDead = true;            
        }

        if (player != null)
        {
            //Debug.Log("player is here!!");

        }
        else if(playerDead ==true)
        {
//            playerDead=false;
            respawn();

        }

    }

    void respawn() 
    {
        Invoke("FollowPlayer", 1.5f);
        playerDead = false;
        PrefabUtility.InstantiatePrefab(playerPrefab.gameObject as GameObject);
    }
    void FollowPlayer()
    {
        playerCam.m_Follow = player.transform;
    }
}
