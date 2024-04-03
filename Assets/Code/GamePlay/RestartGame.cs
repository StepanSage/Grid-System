using System;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public event Action RestartCallBack;

    private Button _restart;
    private void Start()
    {
        _restart= GetComponent<Button>();
        _restart.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Debug.Log("+++");
        RestartCallBack?.Invoke();
    }
}
