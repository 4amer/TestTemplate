using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : BaseWindowWithData<MenuWindowData>
{
    private void Start()
    {
        
    }
    public void StartGame()
    {
        Debug.Log("Button pressed");
        GlobalContext.TestManager.startTest();
    }
}
