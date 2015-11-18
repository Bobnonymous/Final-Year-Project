using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{

    string cardName;
    int cardPower, cardToughness;
    Texture2D cardImage;
    public Card(string name, int power, int toughness)
    {
        this.cardName = name;
        this.cardPower = power;
        this.cardToughness = toughness;
    }
}