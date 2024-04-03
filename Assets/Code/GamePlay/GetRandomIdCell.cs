using Code.Grid;
using System;
using UnityEngine;
using Zenject;

public class GetRandomIdCell : MonoBehaviour
{

    public Action<string> IDCallBack;

    private ViewGridContener _gridContener;

    [Inject]
    public void Init(ViewGridContener viewGridContener)
    {
        _gridContener = viewGridContener;
    }
    private void OnEnable()
    {
        _gridContener.GridCallBack += RandomCell;
    }
    private void OnDisable()
    {
        _gridContener.GridCallBack += RandomCell;
    }

    private void RandomCell(GameObject[,] grid)
    {
        int row = ApplyRandom(0, grid.GetLength(0));
        int column = ApplyRandom(0, grid.GetLength(1));
        Cell cell =  grid[row,column].GetComponent<Cell>();
        IDCallBack?.Invoke(cell.GetID());
    }

    private int ApplyRandom(int min, int max)
    {
        return UnityEngine.Random.Range(min, max);
    }

   
}
