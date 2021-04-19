using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item
{
    Weapon,
    Shield,
    Portion,
}
public struct Youtube
{
    int a;

    public void GetA(int value)
    {
        a = value
    }
}
public class Part11 : MonoBehaviour
{
    Item item;

    Youtube LIMMM;
    // Start is called before the first frame update
    void Start()
    {
        LIMMM.a = 5;

        LIMMM.GetA(5);

        print(LIMMM.a);

        item = Item.Weapon;
        item = Item.Shield;

        print(item);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
