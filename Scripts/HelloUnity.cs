using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        int age = 30;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);

        // float 소수점 아래 7자리까지 : 32비트
        float height = 175.6789f;

        // float 의 두배의 메모리 사용 : 64비트
        double PI = 3.14159265359;

        // bool 참 거짓
        bool isBoy = true;
 

        // char 문자 저장
        char grade = 'A';

        // string 문장

        string movieTitle = "lovelive";

        Debug.Log("내 나이! : " + age);
        Debug.Log("내가 가진 돈은! : " + money);
        Debug.Log("내 키는! : " + height);
        Debug.Log("원주율은! : " + PI);
        Debug.Log("내 성적은! : " + grade);
        Debug.Log("나는 남자인가? " + isBoy);
        Debug.Log("좋아하는 영화는? :" + movieTitle);

        var myName = "I__Jooyoung";
        var myAge = 30;
        //let myName = "I_Jooyoung";

        Debug.Log("주영의 아이디 :" + myName);
        Debug.Log("주영의 나이 :" + myAge);
    }

}



