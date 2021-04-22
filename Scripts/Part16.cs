using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class A : MonoBehaviour
{
    abstract public void Abc();
}

interface ITest
{
    void Bbc();
}

interface ITest2 : ITest
{
    void Bbc();
}

public class Part16 : A, ITest2
{
    

    public override void Abc()
    {
        print("cc");
    }

    public void Bbc()
    {
        print("oo");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
