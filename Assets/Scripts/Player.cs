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

    
    public void XDraw(int numberDrawn) {
        //cardsInHand.Add(cardsInDeck.Last<Card>());//maybe should be lastOrDefault?
        //cardsInDeck.RemoveAt(cardsInDeck.Count - 1);//removes the card from the deck and adds it to the hand
    }

    public Card Draw(int sumint)
    {
        return cardsInDeck.Last();
    }
}
