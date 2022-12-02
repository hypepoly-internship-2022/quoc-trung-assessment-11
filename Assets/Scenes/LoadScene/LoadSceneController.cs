using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class LoadSceneController : Controller
{
    public const string LOADSCENE_SCENE_NAME = "LoadScene";

    public override string SceneName()
    {
        return LOADSCENE_SCENE_NAME;
    }
}