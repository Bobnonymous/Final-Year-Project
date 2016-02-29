using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour {


    public Button playButton;
    public Button editDeckButton;
    public Button quitButton;

	// Use this for initialization
	void Start () {
        
    }
	
    public void Play() {
        print("boats and hoes");
        SceneManager.LoadScene("playMenu");
    }

    public void DeckEdit()
    {
        SceneManager.LoadScene("deckEditMenu");
    }
    
    public void Quit() {
        print("boats and hoes");

        Application.Quit();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
