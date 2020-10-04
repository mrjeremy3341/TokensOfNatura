using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardData : ScriptableObject
{
    public new string name;
    public Element element;

    public Sprite artwork;
    
    public int attack;
    public int health;
    public int monarch;
}
