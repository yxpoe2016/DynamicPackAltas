using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLogic : MonoBehaviour
{
    private ShowItem selectItem;

    private IconItem iItem;

    // Start is called before the first frame update
    void Start()
    {
        ShowName id = ShowName.ICON1;
        foreach (Transform tran in transform)
        {
            IconItem ii = tran.gameObject.AddComponent<IconItem>();
            ShowItem si = tran.gameObject.AddComponent<ShowItem>();
          
        
            si.Init(id);
            id++;
        

            si.AddListener(() =>
            {
                selectItem = si;
                iItem = ii;
            });
        }

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShowIcon(Sprite s, string p)
    {
        if(selectItem ==null)
            return;
        selectItem.setShowItem(s);
        iItem.path = p;
    }

    public Dictionary<string, string> GetPaths()
    {
        Dictionary<string, string> temp = new Dictionary<string, string>();
        KeyValuePair<string, string> tempPair;
        foreach (ShowItem item in GetComponentsInChildren<ShowItem>())
        {
            tempPair = item.GetData();
            temp.Add(tempPair.Key,tempPair.Value);

        }

        return temp;
    }
}
