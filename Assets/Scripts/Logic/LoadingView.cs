using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveState(bool isShow)
    {
        gameObject.SetActive(isShow);
    }

    public void SwitchScene(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    private IEnumerator LoadScene(string sceneName)
    {
       AsyncOperation async =  SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            Debug.Log(async.progress);
            if (async.progress>=0.9f)
            {
                yield return new WaitForSeconds(2);
                async.allowSceneActivation = true;
            }

            yield return new WaitForSeconds(0.5f);
        }
        
    }
}
