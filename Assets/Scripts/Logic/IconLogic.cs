using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconLogic : MonoBehaviour
{
    private Action<Sprite, string> iconAction;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var child in GetComponentsInChildren<Button>())
        {
            child.onClick.AddListener(() =>
            {
                Sprite s = child.GetComponent<Image>().sprite;
                IconItem ii = child.GetComponent<IconItem>();


                if (iconAction!=null)
                {
                    iconAction(s,ii.path);
                }
            });
        }
    }

    public void ActionListen(Action<Sprite,string> a)
    {
        iconAction = a;
    }
}
