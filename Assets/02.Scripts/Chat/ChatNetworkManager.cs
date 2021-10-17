using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class ChatNetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject ChatPanel;
    public Text[] ChatText;
    public InputField ChatInput;

    public GameObject SendBtn;

    public GameObject mainInputField;

    public PhotonView PV;

    public void ChatOpen()
    {
        ChatPanel.SetActive(true);
    }

    public void ChatClose()
    {
        ChatPanel.SetActive(false);
    }

    void Update()
    {
        if (mainInputField.GetComponent<InputField>().isFocused == true)
        {
            mainInputField.GetComponent<Image>().color = new Color(255, 255, 255, 1.0f);
            ChatInput.placeholder.color = new Color(50, 50, 50, 0.5f);
            SendBtn.SetActive(true);
        }

        else
        {
            mainInputField.GetComponent<Image>().color = new Color(255, 255, 255, 0.0f);
            ChatInput.placeholder.color = new Color(50, 50, 50, 0.0f);
            SendBtn.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Send();
            ChatInput.ActivateInputField();
            ChatInput.Select();
        }
    }


    #region 채팅
    public void Send()
    {
        if (ChatInput.text != "")
        {
            PV.RPC("ChatRPC", RpcTarget.All, PhotonNetwork.NickName + " : " + ChatInput.text);
            ChatInput.text = "";
        }
    }

    [PunRPC] // RPC는 플레이어가 속해있는 방 모든 인원에게 전달한다
    void ChatRPC(string msg)
    {
        bool isInput = false;
        for (int i = 0; i < ChatText.Length; i++)
            if (ChatText[i].text == "")
            {
                isInput = true;
                ChatText[i].text = msg;
                break;
            }
        if (!isInput) // 꽉차면 한칸씩 위로 올림
        {
            for (int i = 1; i < ChatText.Length; i++) ChatText[i - 1].text = ChatText[i].text;
            ChatText[ChatText.Length - 1].text = msg;
        }
    }
    #endregion
}