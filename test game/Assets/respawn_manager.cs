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
    public int playerNum = 0;
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
            //Debug.Log("player is here!!");

        }
        else if(playerNum <1)
        {
            playerNum++;
            respawn();

        }
    }

    void respawn() 
    {
        Invoke("FollowPlayer", 1.5f);
        playerNum = 0;
        PrefabUtility.InstantiatePrefab(playerPrefab.gameObject as GameObject);
    }
    void FollowPlayer()
    {
        playerCam.m_Follow = player.transform;
    }
}
