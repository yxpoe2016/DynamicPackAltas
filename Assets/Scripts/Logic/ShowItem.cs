using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum ShowName
{
    ICON1,
    ICON2,
    ICON3,
}
public class ShowItem : MonoBehaviour
{


    public ShowName ID { get; private set; }

    private Image image;

    private IconItem ii;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Init(ShowName id)
    {
        ID = id;
        image = GetComponent<Image>();
        ii = GetComponent<IconItem>();
    }

    public void setShowItem(Sprite s)
    {
        image.sprite = s;
    }

    public void AddListener(Action selected)
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() => { selected(); });
    }

    public KeyValuePair<string, string> GetData()
    {
        return new KeyValuePair<string, string>(ID.ToString(),ii.path);
    }
}
