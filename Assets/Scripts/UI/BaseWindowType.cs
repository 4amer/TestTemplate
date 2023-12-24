using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class BaseWindowType
{
    [SerializeField] private EWindows windowsType;
    [SerializeField] private GameObject windowPrefab = null;

    public EWindows getWindowType { get { return windowsType; } }
    public GameObject getWindowPrefab { get {  return windowPrefab; } }
}
