using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 {

    public GameObject pGO;
    SpriteRenderer sr;
    Sprite playersprite;

    public Player2(string name, int posx, int posy, string pic)
    {
        pGO = new GameObject(name);
        Vector3 startpos = new Vector3(posx, posy, 0);
        pGO.transform.position = startpos;
        Toolbox.AddSpriteToGO(pGO, pic);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update () {
		
	}
}
