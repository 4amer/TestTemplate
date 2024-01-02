using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalManager : MonoBehaviour
{
    public void ReloadScene()
    {
        int currentSceneId = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneId);
    }

    public void WaitFor(float time, Action Event)
    {
        StartCoroutine(WaitForCoroutine(time, Event));
    }

    IEnumerator WaitForCoroutine(float time, Action Event)
    {
        yield return new WaitForSeconds(time);
        Event();
    }

    public void OnLoadWindowAction()
    {

    }

}
