using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class DisplayedCardBehavior : MonoBehaviour
{
    Image img;
    protected Card card;
    void Awake()
    {
        img = GetComponentInChildren<Image>();
        try
        {   
            img.sprite = card.Sprite;//cardは継承先で設定
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("DisplayedCardBehaviorクラスで,cardが正しく設定されてなさそう");
        }
    }
    void Update()
    {
        
    }
}
