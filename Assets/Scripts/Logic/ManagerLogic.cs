using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLogic : MonoBehaviour
{
    private SelectLogic sl;
    void Start()
    {
        GetComponentInChildren<IconLogic>().ActionListen(ShowIcon);
        sl = GetComponentInChildren<SelectLogic>();
        GetComponentInChildren<SelectedComplete>().Init(()=>sl.GetPaths(),
            GetComponentInChildren<LoadingView>(true));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ShowIcon(Sprite s, string p)
    {
        if (sl == null)
        return;
        sl.SetShowIcon(s,p);
    }
}
