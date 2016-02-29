using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;


public class PlayController : MonoBehaviour {

    int startingLifeTotal = 20;
    int startingHandSize = 6;

    //public string json;

    //public Card tempCard = new Card();
    public GameObject canvas;
    public GameObject gameController;

    //public string temp;
    //public string playerDeckName;

    void Start () {

        canvas = GameObject.Find("Canvas");
        gameController = GameObject.Find("Game Controller");

        Player player = gameObject.AddComponent<Player>();
        Player opponent = gameObject.AddComponent<Player>();

        player.playerName = "player";
        opponent.playerName = gameController.GetComponent<GameController>().opponent;
               
        //construct decks
        player.cardsInDeck = ConstructDeck(player.playerName);
        opponent.cardsInDeck =  ConstructDeck(opponent.playerName);

        //set starting life totals
        player.lifeTotal = startingLifeTotal;
        opponent.lifeTotal = startingLifeTotal;

        //draw opening hands
        player.Draw(startingHandSize);
        opponent.Draw(startingHandSize);
    }
	
	void Update () {
	    
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

    //Takes in a deckname and returns a list of card objects with each listed card
    List<Card> ConstructDeck (String playerName) {
        string[] deckList = File.ReadAllText("Assets\\Decks\\" + playerName + ".txt").Split(',');
        List<Card> deck = new List<Card>();

        foreach (string card in deckList) {
            deck.Add(JsonUtility.FromJson<Card>(File.ReadAllText("Assets\\JsonCards\\" + card + ".json")));
        }
        return deck;
    }

    
}
