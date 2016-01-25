using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class PlayController : MonoBehaviour {

    public List<string> deckList = new List<string>();
    public string json;

    public List<Card> deck = new List<Card>();
    public List<Card> hand = new List<Card>();
    public List<Card> play = new List<Card>();

    // Use this for initialization
    void Start () {
        deckList.Add("Assets\\JsonCards\\meanotaur.json");

        for (int i = 0; i < deckList.Count; i++) {
            using (StreamReader reader = new StreamReader(deckList[i])) {
                //public string json = reader.ReadToEnd();
                json = reader.ReadToEnd();
                Card temp = Assemble(json);
            }

        }
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    Card Assemble(string cardName)
    {
        return null;
    }


    void Draw(int drawNum) {
        
    }

    void Shuffle() {
        
    }
}
