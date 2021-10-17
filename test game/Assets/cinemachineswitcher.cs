using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cinemachineswitcher : MonoBehaviour
{
    public Animator animator;
    private bool player_cam =true;
    [SerializeField]
    private CinemachineVirtualCamera vcam1;//player cam
    [SerializeField]
    private CinemachineVirtualCamera vcam2;//boss cam
    void Start()
    {
    
    }
     void Update()
    {
        if (animator != null)
        { 
           if (animator.GetBool("InRoom") == true)
            {
                SwitchPriority();
            }        
        }

    }
    void SwitchPriority()
    {
        if (player_cam)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
        player_cam = !player_cam;
    }
}
