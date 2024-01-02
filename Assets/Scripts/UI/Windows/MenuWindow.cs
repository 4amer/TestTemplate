using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : BaseWindowWithData<MenuWindowData>
{
    [SerializeField] private TextMeshProUGUI _testTitle;
    private void Start()
    {
        _testTitle.text = GlobalContext.TestData.TestTitle;
    }
    public void StartGame()
    {
        Debug.Log("Button pressed");
        GlobalContext.TestManager.startTest();
    }
}
