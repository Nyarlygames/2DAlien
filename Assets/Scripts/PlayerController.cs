using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector3 wantedPos;
    Vector3 goal;
    Vector3 mousePos;
    public float moveSpeed = 2.0f;  // Units per second
    // Use this for initialization
    void Start () {
        wantedPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

    }
    
    
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            goal = new Vector3(mousePos.x, mousePos.y, 0);
            wantedPos = Camera.main.ScreenToWorldPoint(goal);
            wantedPos.z = 0;
        }
        else if (transform.position != wantedPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
            Debug.Log("test" + wantedPos);
        }
        else
        {
            Debug.Log("done" + transform.position);
        }
    }
}
