using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    public GameObject pGO;
    SpriteRenderer sr;
    Sprite playersprite;
    Rigidbody2D playerbody;

    public Player(string name, int posx, int posy, string pic)
    {
        pGO = new GameObject(name);
        Vector3 startpos = new Vector3(posx, posy, 0);
        pGO.transform.position = startpos;
        Toolbox.AddSpriteToGO(pGO, pic);
        pGO.AddComponent<PlayerController>();
        pGO.AddComponent<BoxCollider2D>();
        playerbody = pGO.AddComponent<Rigidbody2D>() as Rigidbody2D;
        playerbody.gravityScale = 0.0f;
        playerbody.freezeRotation = true;

    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}
}
