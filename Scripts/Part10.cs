using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LIMMM.Studio;
using LIMMM;


// 협업, 대형 프로젝트, 외부 라이브러리

namespace LIMMM
{

    public class Youtube
    {
        public int subscribe;
    }
    namespace Studio
    {

        public class Youtube
        {
            int like;

            public void SetLike(int value)
            {
                like = value;
            }

            public bool IsLike()
            {
                return like != 0;
            }
        }
    }
}
public class Part10 : MonoBehaviour
{
    LIMMM.Youtube LIMMM = new LIMMM.Youtube();

    // Start is called before the first frame update
    void Start()
    {
    

        LIMMM.subscribe = 15;

        print(LIMMM.subscribe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
