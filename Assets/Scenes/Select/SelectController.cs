using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class SelectController : Controller
{
    public const string SELECT_SCENE_NAME = "Select";

    public override string SceneName()
    {
        return SELECT_SCENE_NAME;
    }
    public void OnGameButtonTap()
    {
        Manager.Add(GameController.GAME_SCENE_NAME);
    }
}