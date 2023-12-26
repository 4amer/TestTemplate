using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : BaseWindowWithData<MenuWindowData>
{
    public void StartGame()
    {
        Debug.Log("Button pressed");
        GlobalContext.TestManager.startTest();
    }
}
