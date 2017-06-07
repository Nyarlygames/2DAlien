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
        //Debug.Log("1 : " + p.GetComponent<SpriteRenderer>().sprite.border);
        //Debug.Log("3 : " + p.GetComponent<SpriteRenderer>().bounds);
        /* Debug.Log("4 : " + p.GetComponent<Sprite>().bounds);
         Debug.Log("5 : " + p.GetComponent<Sprite>().border);*/
       // leftboundx = new Vector3(-0.15f, transform.position.y, transform.position.z);
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            goal = new Vector3(mousePos.x, mousePos.y, 0);
            
            // Debug.Log("mousePos : " + mousePos);
            // Debug.Log("bounds : " + this.GetComponent<SpriteRenderer>().sprite.bounds);
            // Debug.Log("goal : " + goal);
                wantedPos = Camera.main.ScreenToWorldPoint(goal);
                wantedPos.z = transform.position.z;
            //  Debug.Log("wanted :" + wantedPos);
            /*Debug.Log("wanted : " + wantedPos);
            if (wantedPos.x <= p.GetComponent<SpriteRenderer>().sprite.bounds.extents.x/2)
            {
                wantedPos.x = p.GetComponent<SpriteRenderer>().sprite.bounds.extents.x/2;
            }
            Debug.Log("wantedafter : " + wantedPos);*/
        }
        else if (transform.position != wantedPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
            /*var boundmax = new Vector3(this.GetComponent<SpriteRenderer>().sprite.bounds.extents.x, this.GetComponent<SpriteRenderer>().sprite.bounds.extents.y, transform.position.z) + transform.position;
            if (boundmax.x > 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
                Debug.Log("nop");
            }
            else if (boundmax.x < 0)
            {
                Debug.Log("BE : " + transform.position);
                Debug.Log("BEwant : " + wantedPos);
                Debug.Log("BEx : " + transform.position.x);
                Debug.Log("BEwantx : " + wantedPos.x);
                transform.position = new Vector3(transform.position.x * 2 + 0.01f, transform.position.y *2, transform.position.z *2) - transform.position;
                wantedPos = transform.position;
                Debug.Log("AF : " + transform.position);
               //Vector3 offsetleft = new Vector3(this.GetComponent<SpriteRenderer>().sprite.bounds.extents.x, transform.position.y, transform.position.z);
               //var boundleft = new Vector3(this.GetComponent<SpriteRenderer>().sprite.bounds.extents.x + 1.0f, this.GetComponent<SpriteRenderer>().sprite.bounds.extents.y, 0.0f) + transform.position;
               // Debug.Log("leftbound" + boundleft);
               // Debug.Log("go back to 0" + boundleft);
               //transform.position = wantedPos;
               // wantedPos = boundleft;
            }
            else 
            {
                // if (boundmax.x == 0), right on it
                Debug.Log("boundmax");
            }*/
            // Debug.Log("wanted :" + wantedPos);

            /*if (transform.position.x < leftboundx.x)
            {
                Debug.Log("resetpl");
                transform.position = leftboundx;
                wantedPos = leftboundx;
            }*/

            /*if ((GM != null) && (wantedPos.x + 1.5f >= GM.GetComponent<GameManager>().maxx))
            {
                transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
                Debug.Log("trop droite");
            }
            else if ((GM != null) && (wantedPos.x - 0.25f <= 0.0f)) { 
                transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
                Debug.Log("trop gauche");
            }
              else if ((GM != null) && (wantedPos.y <= this.gameObject.GetComponent<BoxCollider2D>().size.y  )) // 0.05
              {
                  transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
                  Debug.Log("trop bas");
              }
            else if ((GM != null) && (wantedPos.y - 0.80f >= GM.GetComponent<GameManager>().maxy))
            {
                transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
                Debug.Log("trop haut");
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, wantedPos, moveSpeed * Time.deltaTime);
            }*/
            // Debug.Log("test" + wantedPos);
        }
        else
        {
            //arrived on target
            //Debug.Log("done" + transform.position);
        }
    }
}
