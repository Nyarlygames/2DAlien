using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;       //Public variable to store a reference to the player game object
    public GameObject[][] Board;       //Public variable to store a reference to the player game object
    public GameObject maincam;       //Public variable to store a reference to the player game object
    public float leftboundx;
    public float downboundy;
    public float upboundy;
    public float rightboundx;
    public Vector3 clamptoplayer;
    public Vector3 reset;
    public Vector3 camsize;

    // Use this for initialization
    void Start()
    {
        if (player != null)
        {
            camsize = maincam.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(maincam.GetComponentInChildren<Canvas>().pixelRect.width, maincam.GetComponentInChildren<Canvas>().pixelRect.height, 0));
        }
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (player != null)
        {
            clamptoplayer = new Vector3(player.transform.position.x, player.transform.position.y, -20); // to keep zsort
            transform.position = clamptoplayer;
            leftboundx = camsize.x -1.25f; // player size ?
            downboundy = camsize.y - 1.25f;
            if ((Board != null) && (Board.Length > 0)){
                rightboundx = Board[0].Length * (Board[0][0].transform.localScale.x/2) - camsize.x +0.75f;
                upboundy = Board.Length * (Board[0][0].transform.localScale.y/2) - camsize.y + 0.75f;
            }
            else
            {
                Debug.Log("big fail, no board in cam");
            }
            if (player.transform.position.x < leftboundx) {
                reset.x = leftboundx;
                reset.y = transform.position.y;
                reset.z = transform.position.z;
                transform.position = reset;
            }

            if (player.transform.position.y < downboundy)
            {
                reset.x = transform.position.x;
                reset.y = downboundy;
                reset.z = transform.position.z;
                transform.position = reset;
            }

            if (player.transform.position.y >= upboundy)
            {
                reset.x = transform.position.x;
                reset.y = upboundy;
                reset.z = transform.position.z;
                transform.position = reset;
            }

            if (player.transform.position.x >= rightboundx)
            {
                reset.x = rightboundx;
                reset.y = transform.position.y;
                reset.z = transform.position.z;
                transform.position = reset;
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
