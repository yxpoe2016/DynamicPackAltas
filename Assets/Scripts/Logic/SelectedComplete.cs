using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SceneName
{
    SampleScene,
    Scene2,
}

public class SelectedComplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Init(Func<Dictionary<string, string>> getPaths,LoadingView lv)
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //loading view
            lv.SetActiveState(true);
            AssetPackerMgr.Instance.GenTatorNewAltas("Test", getPaths(), () =>lv.SwitchScene(SceneName.Scene2.ToString()));
        });
    }

}
