using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Part13 : MonoBehaviour
{
    protected string humanName;
    public int humanAge;

    protected virtual void Info()
    {
        print("나는 사람입니다.");
    }

    abstract protected void Name();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
