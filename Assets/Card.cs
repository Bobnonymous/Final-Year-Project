using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    string cardName;
    int cardPower, cardToughness;
    public Card(string name, int power, int toughness)
    {
        this.cardName = name;
        this.cardPower = power;
        this.cardToughness = toughness;
    }
    
        // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
