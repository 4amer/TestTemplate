using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer
{
    [SerializeField] private string _text = string.Empty;
    [SerializeField] private bool _isCorrectly = false;
    [SerializeField] private int _score = 0;

    public string Text{
        get { return _text; }}

    public bool IsCurrectly{
        get { return _isCorrectly; }}

    public int Score { 
        get { return _score; }}
}
