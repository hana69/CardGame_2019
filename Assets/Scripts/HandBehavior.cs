using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HandBehavior : MonoBehaviour
{
    [SerializeField]
    int firstHandNum = 5;
    [SerializeField]
    int displayableCardNum = 7;

    [SerializeField]
    DeckBehavior deck;
    PrefabManagerBehavior prefabManager;

    List<CardInHandBehavior> cards;
    void Awake()
    {
        prefabManager = GameObject.Find("PrefabManager").GetComponent<PrefabManagerBehavior>();
       
        cards = new List<CardInHandBehavior>();
    }

    //デュエル開始時に呼ぶ関数
    public void Stumby()
    {
        Enumerable.Range(0, firstHandNum).ToList().ForEach(i => DrawDeckTopCard());
    }

    public void DrawDeckTopCard()
    {
        AddCard(deck.DrawDeckTopCard());
    }

    //引数のカードを手札に加える
    void AddCard(Card card)
    {
        CardInHandBehavior newCard = prefabManager.Instantiate(card);
        if (newCard == null) return;
        newCard.transform.SetParent(this.transform);
        cards.Add(newCard);
        SetCardPositon();
    }

    [SerializeField]
    int center = 0;
    [SerializeField]
    int overWidth=100;
    //カード(のObject)の位置を調整する
    void SetCardPositon()
    {
        if (cards.Count == 0) return;

        RectTransform[] rects = cards.Select(c => c.GetComponent<RectTransform>()).ToArray();

        float width = rects[0].sizeDelta.x;
        float height = rects[0].sizeDelta.y;
        float x0 = center - (overWidth * (cards.Count - 1) + width) / 2;
        rects[0].anchoredPosition = new Vector2(x0 , -height/*画面の下側に合わせる*/);
        for(int i = 1; i < cards.Count;i++)
        {
            rects[i].anchoredPosition = new Vector2(rects[i - 1].anchoredPosition.x + overWidth , -height/*画面の下側に合わせる*/);
        }

    }
        
}
