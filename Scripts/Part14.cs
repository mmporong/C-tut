using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14 : MonoBehaviour
{
    private int salary;

    private int bonus = 10;

    public int SalaryP
    {
        get
        {
            return salary + bonus;
        }
        set
        {
            if (value < 0)
            {
                salary = 10;
            }
            else
            {
                salary = value;
            }
        }
    }

    public int Bonus { get; set; }



    // Start is called before the first frame update
    void Start()
    {
        Bonus = 3;
        print(Bonus);
        SalaryP = 10;

        print(SalaryP);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
