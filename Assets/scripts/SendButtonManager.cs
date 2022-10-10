using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendButtonManager : MonoBehaviour
{
    public GameObject sendedTextBoxPrefab;

    public GameObject sendButton;

    private static SendButtonManager instance = null;

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

    public static SendButtonManager Instance
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

    public void OnSendButtonClick()
    {
        string inputText = SendInputFieldManager.Instance.sendInputField.GetComponent<InputField>().text;
        GameObject sendedTextBox = Instantiate(sendedTextBoxPrefab, ScrollContentManager.Instance.scrollContent.gameObject.transform);
        sendedTextBox.GetComponent<Text>().text = inputText;
        SendInputFieldManager.Instance.sendInputField.GetComponent<InputField>().text = "";
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
