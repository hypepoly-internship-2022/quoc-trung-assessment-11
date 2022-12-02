using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using TMPro;

public class PopupController : Controller
{
    public const string POPUP_SCENE_NAME = "Popup";
    [SerializeField] TextMeshProUGUI m_Text;
    string m_Data = string.Empty;

    public override string SceneName()
    {
        return POPUP_SCENE_NAME;
    }
    public override void OnActive(object data = null)
    {
        if (data != null)
        {
            m_Data = data.ToString();
            m_Text.text = m_Data;
        }
        Debug.Log(data + " OnActive");
    }
}