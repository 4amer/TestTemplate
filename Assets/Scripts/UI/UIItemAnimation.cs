using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class UIItemAnimation : MonoBehaviour
{
    [SerializeField] private GameObject UIItem;

    [SerializeField] private int layer;

    private Animation _itemAnimator;

    private GameObject newUIItem;
    public void Init(GameObject parant)
    {
        newUIItem = Instantiate(UIItem);

        if (UIItem.GetComponent<RectTransform>() == null)
        {
            Debug.LogError(UIItem.name + " is not UI object!");
            return;
        }
        if (UIItem.GetComponent<Animation>() == null)
        {
            Debug.LogError(UIItem.name + " doesnt have an animator!");
            return;
        }
        RectTransform rectTransform = newUIItem.GetComponent<RectTransform>();
        rectTransform.parent = parant.GetComponent<Transform>();
        rectTransform.localScale = new Vector2(1, 1);
        rectTransform.offsetMin = new Vector2(0, 0);
        rectTransform.offsetMax = new Vector2(1, 1);
        rectTransform.SetSiblingIndex(layer);
        newUIItem.SetActive(false);
        _itemAnimator = newUIItem.GetComponent<Animation>();
    }
    public void playAnimationWithAction(String animtionClipName, Action action)
    {
        AnimationClip clip = _itemAnimator.GetClip(animtionClipName);
        if (clip == null) 
        { 
            Debug.LogError(animtionClipName + " animation clip is not found"); 
            return; 
        }
        newUIItem.SetActive(true);
        _itemAnimator.Play(animtionClipName);
        Debug.Log(clip.length + " anim length seconds");
        GlobalContext.GlobalManager.WaitFor(clip.length, action);
    }

    public void OffObject()
    {
        newUIItem.SetActive(false);
    }
}
