using Code.Grid;
using UnityEngine;

public class EasyState : FSMState
{
    private ViewGridContener _viewGridContener;
    private int _countRow;
    private int _countColumn;

    public EasyState(FSMDifficuiy FSM, ViewGridContener viewGridContener, int countRow, int countColumn) : base(FSM)
    {
        _viewGridContener = viewGridContener;
        _countRow = countRow;
        _countColumn = countColumn;
    }

    public override void Enter()
    {
        _viewGridContener.GeneratGrid(_countRow,_countColumn);
    }

    public override void Exit()
    {
        _viewGridContener.ClearGrid();
    }

}
