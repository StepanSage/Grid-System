using System;
using UnityEngine;
using Zenject;

public class ComparisonAnswer : MonoBehaviour 
{
    public event Action AnswerCallBack;

    private GetRandomIdCell _getRandomIdCell;
    private ComparCollider _comparCollider;
    private string _randomID;
    private string _cellID;

    [Inject]
    public void Construcr(GetRandomIdCell getRandomIdCell, ComparCollider comparCollider)
    {
        _getRandomIdCell = getRandomIdCell;
        _comparCollider = comparCollider;
    }

    private void OnEnable()
    {
        _comparCollider.CellIdCallBack += ApplyCellId;
        _getRandomIdCell.IDCallBack += ApllyRandomID;
    }

    private void OnDisable()
    {
        _comparCollider.CellIdCallBack -= ApplyCellId;
        _getRandomIdCell.IDCallBack -= ApllyRandomID;
    }

    private void ApllyRandomID(string id)
    {
        _randomID = id;
    }

    private void ApplyCellId(string CellID)
    {
        _cellID = CellID;
        Answer—orrectly();
    }

    private void Answer—orrectly()
    {
        if(_randomID == _cellID)
        {
            AnswerCallBack();
        }
    }









}
