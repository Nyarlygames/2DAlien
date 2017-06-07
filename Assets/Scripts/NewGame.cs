using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;

public class NewGame : MonoBehaviour {

    public List<GameObject> Players;
    public GameObject cam;
    public GameObject canvas;
    public List<GameObject> WallsPrefabs;
    public List<GameObject> PlayersPrefabs;
    Texture2D tilesetground;
    
    void Start () {
        initialLoad();
    }
	
	void Update () {
    }

    public void initialLoad()
    {
        /*cam = new GameObject();
        cam.tag = "MainCamera";
        cam.name = "MainCamera";
        cam.AddComponent<Camera>();
        cam.AddComponent<CameraController>();*/ 
        cam = Resources.Load("Main Camera") as GameObject;
        cam.tag = "MainCamera";
        cam.name = "MainCamera";
        Instantiate(cam, new Vector3(1.0f, 1.0f, -20.0f), Quaternion.identity);
        
        Load("test.txt");
        //  Debug.Log(PlayerPrefs.GetInt("level"));
    }

    public bool Load(string fileName)
    {
        try
        {
            string line;
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            WallsPrefabs.Add(Resources.Load("Wall1") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall2") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall3") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall4") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall5") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall6") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall7") as GameObject);
            WallsPrefabs.Add(Resources.Load("Wall8") as GameObject);
            PlayersPrefabs.Add(Resources.Load("Player1") as GameObject);
            PlayersPrefabs.Add(Resources.Load("Player2") as GameObject);

            using (theReader)
            {
                do
                {
                    line = theReader.ReadLine();

                    if (line != null)
                    {
                        string[] entries = line.Split(',');
                        if (entries.Length > 0)
                        {
                            switch (entries[0])
                            {
                                case "Spawner":
                                    break;
                                case "Player":
                                    if (Players.Count == 0)
                                    {
                                        Players.Add(Instantiate(PlayersPrefabs[int.Parse(entries[1])], new Vector3(int.Parse(entries[2]), int.Parse(entries[3]), 0), Quaternion.identity));
                                        Players[0].name = "Player";
                                    }
                                    else { 
                                        Players.Add(Instantiate(PlayersPrefabs[int.Parse(entries[1])], new Vector3(int.Parse(entries[2]), int.Parse(entries[3]), 0), Quaternion.identity));
                                        Destroy(Players[Players.Count - 1].GetComponent<PlayerController>());
                                        Players[Players.Count - 1].name = "Player" + (Players.Count - 1);
                                    }
                                    break;
                                case "tilesetground":
                                   // tilesetground = (Texture2D)Resources.Load(entries[1]);
                                   // Wall wall = new Wall(tilesetground);
                                    break;
                                case "tilesetwalls":
                                    break;
                                case "Board":
                                    /*canvas = new GameObject();
                                    //canvas.tag = "Board";
                                    canvas.name = "Board";
                                    Canvas Canvascomp;
                                    Canvascomp = canvas.AddComponent<Canvas>() as Canvas;
                                    Canvascomp.renderMode = RenderMode.ScreenSpaceCamera;
                                    Canvascomp.worldCamera = cam.GetComponent<Camera>();*/


                                    break;
                                case "Wall":
                                    Instantiate(WallsPrefabs[int.Parse(entries[1])], new Vector3(int.Parse(entries[2]), int.Parse(entries[3]), 0), Quaternion.identity);
                                    break;
                                default:
                                    break;
                            }
                            /* int x = 0;
                             while (x < entries.Length)
                             {
                                 Debug.Log(entries[x] + " X : " + x);
                                 x++;
                             }*/
                        }
                    }
                }
                while (line != null);
                theReader.Close();
                return true;
            }
        }
        catch (Exception e)
        {
            Debug.Log("Map not found : " + e);
            return false;
        }
    }
}
