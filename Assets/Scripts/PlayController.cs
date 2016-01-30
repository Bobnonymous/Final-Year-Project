using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;


public class PlayController : MonoBehaviour {

    public string json;

    public Player player = new Player();
    public Player opponent = new Player(); 

    void Start () {
        Draw(player, 6);
	}
	
	// Update is called once per frame
	void Update () {
	    //Canvas.
	}

    void Draw(Player playerDrawing, int cardsDrawn) {
        playerDrawing.cardsInHand.Add(playerDrawing.cardsInDeck.Last());//maybe should be lastOrDefault?
        playerDrawing.cardsInDeck.RemoveAt(playerDrawing.cardsInDeck.Count - 1);//removes the card from the deck and adds it to the hand
    }

    static void Shuffle(Player playerShuffling) {//shuffles a given player's deck
        System.Random random = new System.Random();
        int n = playerShuffling.cardsInDeck.Count();
        for (int i = 0; i < n; i++) {
            int r = i + (int)(random.NextDouble() * (n - i));
            Card temp = playerShuffling.cardsInDeck[r];
            playerShuffling.cardsInDeck[r] = playerShuffling.cardsInDeck[i];
            playerShuffling.cardsInDeck[i] = temp;
        }
    }
}
