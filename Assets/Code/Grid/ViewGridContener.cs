using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Grid
{
    public class ViewGridContener : MonoBehaviour
    {
        #region Action
            public Action<GameObject[,]> GridCallBack;
        #endregion

        [SerializeField] private List<CardData> _cardData;
        [SerializeField] private Cell _prefabCell;

        private int _row;
        private int _col;
        private GameObject[,] _grid;
        private List<CardData> _useCard;
        private GridCard _gridCard;
        private Cell _cell;


        public void Initialized(GridCard gridCard, Cell cell)
        {
            _gridCard= gridCard;
            _cell= cell;
            _useCard = new List<CardData>(_cardData);
        }

        public void GeneratGrid(int countRows, int countColumn)
        {
            _row = countRows;
            _col = countColumn;
            Initialized(new GridCard(_row, _col, 3, _prefabCell.gameObject, transform), new Cell());      
            ApplySpriteCell();
        }

        public void ClearGrid()
        {
            for (int row = 0; row < _row; row++)
            {
                for (int col = 0; col < _col; col++)
                {
                    Destroy(_grid[row, col]);
                }
            }
        }

        private void ApplySpriteCell()
        {  
            _grid = _gridCard.GetGrid();
            for (int row = 0; row < _row; row++)
            {
                for (int col = 0; col < _col; col++)
                {
                    int IndexCard = UnityEngine.Random.Range(0, _useCard.Count);
                    Cell _currentCell = _grid[row, col].GetComponent<Cell>();
                    _currentCell.SetSpriteCard(_useCard[IndexCard].SpriteCard);
                    _currentCell.SetID(_useCard[IndexCard].ID);
                    _useCard.RemoveAt(IndexCard);
                }
            }
            GridCallBack?.Invoke(_grid);
        }
    }
}
