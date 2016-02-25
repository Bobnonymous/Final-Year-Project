using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;


public class PlayController : MonoBehaviour {

    int startingLifeTotal = 20;
    int startingHandSize = 6;

    public string json;

    public Card card;
    public demoClass demo;

    public string temp;
    public string temp2;

    string[] deckList = {"deleteMe", "sum"};

    void Start () {

        Player player = gameObject.AddComponent<Player>();
        Player opponent = gameObject.AddComponent<Player>();

        //construct decks
        int i = 0;
        string temp = "Assets\\JsonCards\\" + deckList[i] + ".json";
        //FileStream fileStream = File.Open(temp, FileMode.Open, FileAccess.Read);
        //string jsonAsString = fileStream.Read();

        temp2 =  File.ReadAllText(temp);
        print("XXX");

        demo = JsonUtility.FromJson<demoClass>(File.ReadAllText(temp));

        //player.cardsInDeck.Add(JsonUtility.FromJson<Card>(File.ReadAllText(temp)));

        //set starting life totals
        player.lifeTotal = startingLifeTotal;
        opponent.lifeTotal = startingLifeTotal;

        //draw opening hands
        player.Draw(startingHandSize);
        opponent.Draw(startingHandSize);
        //Draw(player, startingHandSize);
        //Draw(opponent, startingHandSize);
	}
	
	void Update () {
	    
	}

    //void Draw(Player playerDrawing, int cardsDrawn) {
        //  playerDrawing
        //playerDrawing.cardsInHand.Add(playerDrawing.cardsInDeck.Last());//maybe should be lastOrDefault?
        //playerDrawing.cardsInDeck.RemoveAt(playerDrawing.cardsInDeck.Count - 1);//removes the card from the deck and adds it to the hand
    //}

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
