using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollContentManager : MonoBehaviour
{
    public GameObject scrollContent;
    
    private static ScrollContentManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            // 씬 전환이 되어도 오브젝트를 살리고 싶을 때, 하기 코드 주석 해제 요망.
            // DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // 컴포넌트가 disable 될 때도 Awake() 함수가 호출되므로, 하기의 코드가 필요.
            Destroy(this.gameObject);
        }
    }

    public static ScrollContentManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
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
