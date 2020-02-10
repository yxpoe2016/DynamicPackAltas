using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SpritePathHelper : MonoBehaviour
{
    [MenuItem("GameObject/SpritePathHelper", false, 0)]
    private static void SetPath()
    {
        foreach (GameObject go in Selection.gameObjects)
        {
            foreach (Transform tran in go.transform)
            {
                if (tran.GetComponent<Image>() == null)
                    continue;
                Sprite s = tran.GetComponent<Image>().sprite;
                string path = AssetDatabase.GetAssetPath(s);
                path = Application.dataPath + path.Substring(6);
                Debug.Log(path);
                IconItem ii = tran.GetComponent<IconItem>();
                if (ii == null)
                {
                    tran.gameObject.AddComponent<IconItem>();
                }

                ii.path = path;
            }
        }
     
    }
}
