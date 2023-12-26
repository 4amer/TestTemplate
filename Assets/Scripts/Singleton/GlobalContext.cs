using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalContext : MonoBehaviour
{
    [SerializeField] public UIManager UIManagerObj;
    [SerializeField] public TestManager TestManagerObj;
    
    public static TestData TestData = TestData.Instance;
    public static UIManager UIManager = null;
    public static TestManager TestManager = null;

    private void Awake()
    {
        UIManager = UIManagerObj;
        TestManager = TestManagerObj;
    }
}
