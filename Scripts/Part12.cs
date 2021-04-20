using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part12 : MonoBehaviour
{
    public delegate void ChainFunction(int value);
    public static event ChainFunction OnStart;


    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value + "만큼 증가했습니다. 총 defence의 값 = " + defence);
    }
    // Start is called before the first frame update
    void Start()
    {
        SetPower(5);
        SetDefence(75);

        OnStart += SetPower;
        OnStart += SetDefence;
        // if(chain != null)

        // chain(10);


    }

    private void OnDisable()
    {
        OnStart(7);
    }

}
