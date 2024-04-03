using Code.Service;
using System;
using UnityEngine;

public class InputHeandler : MonoBehaviour, ILisener
{
    public event Action CallBack;

    private void Update()
    {
        
        ClickingLeftButtonMouse();
    }

    private void ClickingLeftButtonMouse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CallBack?.Invoke();
        }
       
    }

}
