using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void LoadStage()
    {
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene("Gamescene");
    }
}
