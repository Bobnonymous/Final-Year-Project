using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public string opponent;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this);
        opponent = "Vigo";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape")){
            Application.Quit();
        }
	}
    
}
