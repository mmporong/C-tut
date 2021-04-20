using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : Part13
{
    string schoolName;

    
    // Start is called before the first frame update
    void Start()
    {
        schoolName = "LIMM school";
        humanName = "LIMMM";
        humanAge = 8;

        Info();
    }

    protected override void Info()
    {
        base.Info();
        print("나는 학생입니다.");
    }

    protected override void Name()
    {
        print(humanName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
