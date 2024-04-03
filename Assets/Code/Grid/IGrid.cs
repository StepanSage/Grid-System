using UnityEngine;

public interface IGrid<T>
{
   
    public T GetGrid(int row, int column);
    public void SetGrid(int row, int column, T obj);
}