using Code.Grid;
using Code.Service;
using System;
using UnityEngine;
using Zenject;

public class ComparCollider: MonoBehaviour
{
    public event Action<string> CellIdCallBack;

    private ILisener _lisener;

    [Inject]
    public void Init(ILisener lisener)
    {
        _lisener = lisener;
       
    }

    private void OnEnable() => _lisener.CallBack += CheckinhCollider;
    private void OnDisable() => _lisener.CallBack -= CheckinhCollider;
    

    public void CheckinhCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
           if(hit.collider.TryGetComponent<Cell>(out Cell component))
           {
                CellIdCallBack?.Invoke(component.GetID());               
           }
        }
    }
    
}
