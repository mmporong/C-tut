using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3 f;

        // height = heightDetail; 자동 형변환
        heightDetail = height;

        height = (int)heightDetail;

        // 조건문 if문
        bool isBoy = true;

        if (isBoy == true) {
            Debug.Log("나는 남자다");
        } else {
            Debug.Log("나는 여자다");
        }

        int love = 60;

        if (love < 50) {
            Debug.Log("배드엔딩");
        } else {
            Debug.Log("해피엔딩");
        }

        int age = 20;

        if (age >= 20) {
            Debug.Log("성인");
        } else {
            Debug.Log("미성년자");

        }

        int year = 2017;

        switch(year)
        {
            case 2012:
                Debug.Log("레미제라블");
                break;

            case 2015:
                Debug.Log("러브라이브");
                break;

            case 2016:
                Debug.Log("곡성");
                break;

            case 2017:
                Debug.Log("트랜스포머5");
                break;

            default:
                Debug.Log("해당 없음");
                break;


        }

    }

}
