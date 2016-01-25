using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape")){
            Application.Quit();
        }
	}
}
