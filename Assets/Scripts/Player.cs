using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Player : MonoBehaviour {

    public string playerName;
    public int lifeTotal;

    //List<string> deckList = new List<string>();
    public List<Card> cardsInDeck = new List<Card>();
    public List<Card> cardsInHand = new List<Card>();
    public List<Card> cardsInPlay = new List<Card>();
    
    void Start () {
        
	}
	
	void Update () {
	
	}

    
    public void Draw(int numberDrawn) {
        for(int i = 0; i < numberDrawn; i++) {
            cardsInHand.Add(cardsInDeck.Last<Card>());
            cardsInDeck.RemoveAt(cardsInDeck.Count - 1);
        }
        //cardsInDeck.RemoveAt(cardsInDeck.Count - 1);//removes the card from the deck and adds it to the hand
    }
}
