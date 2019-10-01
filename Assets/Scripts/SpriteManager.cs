using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpriteManager
{
    public static Dictionary<string,Sprite> SpriteDict { get; private set; }
    static SpriteManager()
    {
        SpriteDict = new Dictionary<string, Sprite> { };
        Sprite[] sprites = Resources.LoadAll<Sprite>("Cards/");
        foreach(var sp in sprites){
            string tmpName = sp.name.Split('.')[0];//拡張子を除く
            SpriteDict.Add(tmpName, sp);
        }
    }
}
