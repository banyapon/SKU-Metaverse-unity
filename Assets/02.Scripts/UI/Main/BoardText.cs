using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BoardText : MonoBehaviour
{
    public Text ButtonText;
    public InputField InputText;
    public Text PostitText;

    string ChectText;
    string[] split_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickInputButton()
    {
        
        //ButtonText.text = InputText.text;
        split_text = InputText.text.Split(' '); //띄어쓰기 기준으로 텍스트 짜름
        for (int i = 0; i < split_text.Length; i++)
        {
            if(i == 0) // 맨처음 텍스트는 바로 넣기
            {
                ButtonText.text = split_text[i];
                PostitText.text = split_text[i];
            }
            else // 두번째 텍스트부터 작업 들어감
            {
                ChectText = split_text[i-1] + split_text[i]; //한줄에 6줄이 넘어가면 안되기 때문에 이전에 넣은 텍스트와 지금 넣을 텍스트를 ChectText에 일단 넣기
                if ((ChectText.Length) > 6) //ChecKText가 6글자가 넘어가면 
                {
                    ButtonText.text = ButtonText.text + System.Environment.NewLine + split_text[i]; //이번에 넣을 텍스트를 줄바꿈한채로 넣기
                    PostitText.text = PostitText.text + System.Environment.NewLine + split_text[i]; //이번에 넣을 텍스트를 줄바꿈한채로 넣기
                    Debug.Log("ButtonText.text :" + ButtonText.text);
                }
                else //6글자가 넘지 않으면
                {
                    ButtonText.text = ButtonText.text + " " + split_text[i]; //띄어쓰기만 넣어주고 바로 넣기
                    PostitText.text = PostitText.text + " " + split_text[i]; //띄어쓰기만 넣어주고 바로 넣기
                }
            }
        }

    }
}
