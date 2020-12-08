using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : Monobehaivior
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
        bool isGirl = false;

        // char 문자 저장
        char grade = 'A';

        // string 문장

        string movieTitle = "lovelive";

        Debug.log("내 나이! : " + age);
        Debug.log("내가 가진 돈은! : " + money);
        Debug.log("내 키는! : " + height);
        Debug.log("원주율은! : " + PI);
        Debug.log("내 성적은! : " + grade);
        Debug.log("나는 남자인가? " + isBoy);
    }

}



