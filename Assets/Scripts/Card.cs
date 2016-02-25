using UnityEngine;
using System.Collections;

[System.Serializable]
public class Card : MonoBehaviour
{

    public string cardName;
    public int manaCost;
    //public Texture2D cardImage;
    public string cardImage;
    public string type;
    public string keywords;
    public string abilityText;

    public int attack;
    public int defence;

    void Awake() {

    }
   
    public Card(string cardName, int manaCost, string type, string keywords, string abilityText, int attack, int defence)
    {
        this.cardName = cardName;
        this.manaCost = manaCost;
        this.cardImage = cardName + ".jpg"; 
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