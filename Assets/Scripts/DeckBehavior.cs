using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DeckBehavior : MonoBehaviour
{
    void Awake()
    {
        cardList = new List<Card>();
         cardList.Add(new OnibiKoumori());
        Enumerable.Range(0, 40).ToList().ForEach(i => cardList.Add(new OnibiKoumori()));
    }

    List<Card> cardList;
    public Card DrawDeckTopCard()
    {
        if (cardList.Count == 0)
        {
            return null;
        }
        Card ret = cardList[0];
        cardList.Remove(ret);
        return ret;
    }
    public Card CardByIndexFromTop(int index)
    {
        return cardList[index];
    }
}
