using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Mesh;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas = null;
    [SerializeField] private BaseWindowType[] windowTypes;
    [SerializeField] private EWindows startWindow = new EWindows();

    private static EWindows currentWindowType;

    private Dictionary<EWindows, BaseWindow> _activeWindow = new Dictionary<EWindows, BaseWindow>();
    private Dictionary<EWindows, GameObject> _windowsGameObject = new Dictionary<EWindows, GameObject>();

    private void Start()
    {
        if (currentWindowType != 0) 
        {
            startWindow = currentWindowType;
            currentWindowType = 0;
        }
        changeWindow(startWindow);
    }

    public void setWindow(EWindows windowTypeChange)
    {
        changeWindow(windowTypeChange);
    }

    private void changeWindow(EWindows windowTypeChange)
    {
        if (IsWindowShow(windowTypeChange)) return;

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
                if (_windowsGameObject.Count != 0)
                {
                    Destroy(_windowsGameObject[currentWindowType]);

                }
                _windowsGameObject.Clear();
                _activeWindow.Clear();
                _windowsGameObject.Add(windowTypeChange, window);
                _activeWindow.Add(windowTypeChange, window.GetComponent<BaseWindow>());
                currentWindowType = windowTypeChange;
                Debug.Log(currentWindowType);
            }
        }
    }

    public Boolean IsWindowShow(EWindows windowType)
    {
        if (windowType == currentWindowType) return true;
        return false;
    }

    public void UpdateWindowData(EWindows windowType, BaseWindowData data)
    {
        if (data == null || !IsWindowShow(windowType)) return;
        _activeWindow[windowType].UpdateWindowData(data);
    }
}
