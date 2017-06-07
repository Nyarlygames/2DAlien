using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;

public class Toolbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public void AddSpriteToGO(GameObject go, string img)
    {
        Texture2D texture = (Texture2D)Resources.Load(img);

        SpriteRenderer sr;
        sr = go.AddComponent<SpriteRenderer>() as SpriteRenderer;

        Sprite sprite;
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);

        sr.sprite = sprite;
    }

    
}
