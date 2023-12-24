using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas = null;
    [SerializeField] private BaseWindowType[] windowTypes;
    [SerializeField] private EWindows startWindow = new EWindows();

    private void Start()
    {
        for (int i = 0; i < windowTypes.Length; i++)
        {
            EWindows type = windowTypes[i].getWindowType;
            if (type == startWindow)
            {
                GameObject window = Instantiate(windowTypes[i].getWindowPrefab);
                window.transform.parent = canvas.transform;
                window.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
            }
        }
    }
}
