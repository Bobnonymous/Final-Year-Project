using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Player : MonoBehaviour {

    public int lifeTotal;

    List<string> deckList = new List<string>();
    public List<Card> cardsInDeck = new List<Card>();
    public List<Card> cardsInHand = new List<Card>();
    public List<Card> cardsInPlay = new List<Card>();
    
    void Start () {
        //lifeTotal = 20;
	}
	
	void Update () {
	
	}

    
    void Draw() {
        cardsInHand.Add(cardsInDeck.Last());//maybe should be lastOrDefault?
        cardsInDeck.RemoveAt(cardsInDeck.Count - 1);//removes the card from the deck and adds it to the hand
    }
}
