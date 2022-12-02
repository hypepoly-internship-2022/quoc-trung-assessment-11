using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class Main : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        Manager.LoadingSceneName = LoadSceneController.LOADSCENE_SCENE_NAME;

        Manager.Load(TopController.TOP_SCENE_NAME);
    }
}
