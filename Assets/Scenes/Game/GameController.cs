using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class GameController : Controller
{
    public const string GAME_SCENE_NAME = "Game";

    public override string SceneName()
    {
        return GAME_SCENE_NAME;
    }
    public void OnButtonTap()
    {
        StartCoroutine(LoadingToTop());
    }
    public override void OnActive(object data = null)
    {
        Debug.Log(SceneName() + " OnActive");
    }

    public override void OnShown()
    {
        Debug.Log(SceneName() + " OnShown");
    }

    public override void OnHidden()
    {
        Debug.Log(SceneName() + " OnHidden");
    }

    IEnumerator LoadingToTop()
    {
        
        Manager.LoadingAnimation(true);

        yield return new WaitForSeconds(1f);

        Manager.LoadingAnimation(false);

        Manager.Load(TopController.TOP_SCENE_NAME);
    }
}