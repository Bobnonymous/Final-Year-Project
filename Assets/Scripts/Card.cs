using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{

    public string cardName;
    int manaCost;

    //Texture2D cardImage;
    string cardImage;
    string type;
    string keywords;
    string abilityText;

    int attack;
    int defence;
   
    public Card(string cardName, int manaCost, string cardImage, string type, string keywords, string abilityText, int attack, int defence)
    {
        this.cardName = cardName;
        this.manaCost = manaCost;
        this.cardImage = cardImage;
        this.type = type;
        this.keywords = keywords;
        this.abilityText = abilityText;
        this.attack = attack;
        this.defence = defence;
    }

    public Card Assemble(string jsonString) {
        return JsonUtility.FromJson<Card>(jsonString);
    }

}