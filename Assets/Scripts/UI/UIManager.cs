using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Mesh;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas = null;
    [SerializeField] private BaseWindowType[] windowTypes;
    [SerializeField] private EWindows startWindow = new EWindows();

    private GameObject currentWindow;

    private void Start()
    {
        changeWindow(startWindow);
    }

    public void setWindow(EWindows windowTypeChange)
    {
        changeWindow(windowTypeChange);
    }

    private void changeWindow(EWindows windowTypeChange)
    {
        Console.WriteLine("Window change method was emit");
        for (int i = 0; i < windowTypes.Length; i++)
        {
            EWindows type = windowTypes[i].getWindowType;
            if (type == windowTypeChange)
            {
                GameObject window = Instantiate(windowTypes[i].getWindowPrefab);
                window.transform.parent = canvas.transform;
                RectTransform windowRectTrandform = window.GetComponent<RectTransform>();
                windowRectTrandform.localScale = new Vector2(1, 1);
                windowRectTrandform.offsetMin = new Vector2(0,0);
                windowRectTrandform.offsetMax = new Vector2(0,0);
                if(currentWindow == null)
                {
                    currentWindow = window;
                    return;
                }
                Destroy(currentWindow);
            }
        }
    }
}
