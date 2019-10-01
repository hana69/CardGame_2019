using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManagerBehavior : MonoBehaviour
{
    Dictionary<string, CardInHandBehavior> prefabDict = null;//カード名をKey,対応するプレハブをvalueとする辞書
    public CardInHandBehavior Instantiate(Card card)
    {
        if (card == null)
        {
            return null;
        }
        return Object.Instantiate<CardInHandBehavior>(prefabDict[card.Name]);
    }
    void Awake()
    {
        prefabDict = new Dictionary<string, CardInHandBehavior>();
        var prefabs = Resources.LoadAll<CardInHandBehavior>("Prefabs/HandCards");
        foreach (var prefab in prefabs)
        {
            string name = prefab.name.Split('_')[0];
            prefabDict[name] = prefab;
        }
    }
}
