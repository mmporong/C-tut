using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    void FloatToInt(float _parameter, float _parameter2, string _stringParm = "default")
    {
        // float을 int로 형변환 
        intValue = (int)(_parameter + _parameter2);
        print(intValue);
        print(_stringParm);
    }

    int FloatToInt2(float _parameter, float _parameter2)
    {
        // float을 int로 형변환 
        return Multiply((int)(_parameter + _parameter2));
    
    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }



    // Start is called before the first frame update
    void Start()
    {
        FloatToInt(floatValue, floatValue2, "테스트");
        print(FloatToInt2(floatValue, floatValue2));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
