using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class TopController : Controller
{
    public const string TOP_SCENE_NAME = "Top";

    public override string SceneName()
    {
        return TOP_SCENE_NAME;
    }
    public void OnButtonTap()
    {
        Manager.Add(PopupController.POPUP_SCENE_NAME, "Popup 1");

        Manager.Add(PopupController.POPUP_SCENE_NAME, "Popup 2");
    }
    public void OnSelectTap()
    {
        Manager.Add(SelectController.SELECT_SCENE_NAME);
    }
}