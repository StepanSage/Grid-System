public abstract class FSMState 
{
    protected readonly FSMDifficuiy Fsm;

    public FSMState(FSMDifficuiy FSM)
    {
        Fsm = FSM;
    }

    public virtual void Enter() { }

    public virtual void Exit() { }

    public virtual void UpDate() { }
   
}
