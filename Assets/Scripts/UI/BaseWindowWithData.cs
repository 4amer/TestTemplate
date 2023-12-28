using System;
using UnityEngine;

public class BaseWindowWithData<TBaseWindowData> : BaseWindow where TBaseWindowData : BaseWindowData
{
    protected TBaseWindowData Data;

    public override void UpdateWindowData(BaseWindowData data)
    {
        base.UpdateWindowData(data);
        if (data == null)
        {
            Debug.LogError("Data for window is null or undefined!");
            return;
        }
        TryUpdateWindowData(data);
    }

    private void TryUpdateWindowData(BaseWindowData data)
    {
        TBaseWindowData correctData = data as TBaseWindowData;
        if (correctData != null)
        {
            Data = correctData;
        }
        else
        {
            Debug.LogError("Try set incorrect data in window");
        }
    }
}
