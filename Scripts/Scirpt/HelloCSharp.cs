using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        
        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        // height = heightDetail;
        // 자동 형변환        
        heightDetail = height;

        height = (int)heightDetail;
        
        // 조건문 if문
        bool isBoy = true;

        if(isBoy == true) {
            Debug.Log("나는 남자다");
        }

        else {
            Debug.Log("나는 여자다");
        }

        int love = 60;

        if(love < 50) 
        {
            Debug.Log("배드엔딩");
        }
        else{
            Debug.Log("해피엔딩");
        }
    
        }
    
    }

}
