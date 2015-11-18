using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    void Start () {
        GameObject handDisplay = GameObject.Find("hand");

        List<Card> deck = new List<Card>();
        List<Card> hand = new List<Card>();

        //demo
        Card eagerCadet = new Card("Eager Cadet", 1, 1);

        for (int i = 0; i < 8; i++)
        {
            deck.Add(eagerCadet);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
