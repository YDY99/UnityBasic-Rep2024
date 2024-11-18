using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string aFriend = "Bill";

        Console.WriteLine(aFriend);
        
        Debug.Log($"내 친구의 이름은 (aFriend)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
