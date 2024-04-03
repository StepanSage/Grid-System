using Code.Grid;
using UnityEngine;

public class FSM : MonoBehaviour
{
    [SerializeField] private ViewGridContener _viewGridContener;
    [SerializeField] private ComparisonAnswer _answer;

    private FSMDifficuiy _fSMDifficuiy;

    private void OnEnable()
    {
        _answer.AnswerCallBack += NextState;
    }

    private void OnDisable()
    {
        _answer.AnswerCallBack -= NextState;
    }

    private void Start()
    {
        _fSMDifficuiy= new FSMDifficuiy(); 
        _fSMDifficuiy.AddState(new EasyState(_fSMDifficuiy, _viewGridContener, 2, 2));
        _fSMDifficuiy.AddState(new MidState(_fSMDifficuiy, _viewGridContener, 3, 2));
        _fSMDifficuiy.AddState(new HardState(_fSMDifficuiy, _viewGridContener, 3, 3));
        _fSMDifficuiy.SetState<EasyState>();
    }

    public void NextState()
    {
        _fSMDifficuiy.NextState();
    }
}
