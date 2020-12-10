using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        float sizeOfCircle = 30;

        float radius = GetRadius(sizeOfCircle);
        Debug.Log("원의 사이즈: " + sizeOfCircle + "원의 반지름: " + radius);
    }

    float GetRadius(float size) {
        float PI = 3.14f;

        float tmp = size / PI;

        float raidus = Mathf.Sqrt(tmp);

        return raidus;

    }
}