using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float offsetSmoothing;
    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(transform.position.x,player.transform.position.y, transform.position.z);
       /* if (player.transform.localScale.x >0) {
            playerPos = new Vector3(playerPos.x+offset, playerPos.y, playerPos.z);
        }
        else
        {
            playerPos = new Vector3(playerPos.x - offset, playerPos.y, playerPos.z);
        }*/
        if (player.transform.localScale.y > 0)
        {
            playerPos = new Vector3(playerPos.x , playerPos.y + offset, playerPos.z);
        }
        else
        {
            playerPos = new Vector3(playerPos.x, playerPos.y - offset, playerPos.z);
        }
        transform.position = Vector3.Lerp(transform.position,playerPos,offsetSmoothing*Time.deltaTime);
    }
}
