using UnityEngine;

namespace Code.Grid
{
    public class GridCard 
    {
        private GameObject[,] _grid; // Матрица для хранения объектов
        private int _rows;
        private int _columns;
        private GameObject _prefab;
        private float _cellSize = 3;
        private Transform _contenerCards;
        private Vector3 position;




        public GridCard(int rows, int columns, float cellSize, GameObject prefab, Transform contenerCards = null )
        {
            _rows = rows;
            _columns = columns;
            _prefab = prefab;
            _grid= new GameObject[rows, columns];
            _contenerCards = contenerCards;
            _cellSize = cellSize;
            CreatGrid();
            
        }

        private void CreatGrid()
        {

            Vector3 gridCenterOffset = new Vector3((_rows - 1) * _cellSize / 2, (_columns - 1) * _cellSize / 2, 0);

            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                
                    position = new Vector3(row * _cellSize, col * _cellSize, 0) - gridCenterOffset;
                    _grid[row, col] = GameObject.Instantiate(_prefab, position, Quaternion.identity, _contenerCards);
                }
            }
        }

        public int GetSizeGrid() => _rows + _columns;      

        public GameObject[,] GetGrid() => _grid;

        public GameObject GetGridCell(int row, int column) => _grid[row,column]; 
 
        public void SetGrid(int row, int column, GameObject obj)
        {
            _grid[row, column] = obj;
        }
    }
}
