using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectoryState : FSMState
{
    private AbstractWindow _victoryWindow;
    

    public VectoryState(FSMDifficuiy FSMS, AbstractWindow victoryWindow) : base(FSMS)
    {
        _victoryWindow = victoryWindow;
    }

    public override void Enter()
    {
       _victoryWindow.Show();
    }
}
