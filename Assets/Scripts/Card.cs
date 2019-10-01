using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string Name { get; protected set; }
    public Sprite Sprite { get; protected set; }
}

public class OnibiKoumori:Card
{
    public OnibiKoumori()
    {
        Name = "鬼火蝙蝠";
        Sprite = SpriteManager.SpriteDict[Name];
    }
}