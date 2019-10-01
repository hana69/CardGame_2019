using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemBehavior : MonoBehaviour
{
    [SerializeField]
    HandBehavior hand;
    void Start()
    {
        hand.Stumby();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            hand.DrawDeckTopCard();
        }
    }
}
