using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class FSMDifficuiy 
{
    private FSMState _currentState;

    private Dictionary<Type, FSMState> _states = new();

    public void AddState(FSMState state)
    {
        _states.Add(state.GetType(), state);
    }

    public void SetState<T>() where T : FSMState
    {
        var state = typeof(T);

        if(_currentState != null &&  _currentState.GetType() == state  ) 
        {
            return;
        }

        if(_states.TryGetValue(state, out var states))
        {
            HeandlerState(states);
        }
    }

    public void NextState()
    {
        Type keyCurrentState = _states.FirstOrDefault(x => x.Value == _currentState).Key;
       
        bool _isNext = false;

        foreach (Type key in _states.Keys)
        {
            if(_isNext == true)
            {
               FSMState state = _states[key];
               HeandlerState(state);
                break;
            }

            if(key == keyCurrentState)
            {
                _isNext = true;
            }
        }  
    }


    public void SetUpDate()
    {
        _currentState.UpDate();
    }

    private void HeandlerState(FSMState state)
    {
        _currentState?.Exit();
        _currentState = state;
        _currentState.Enter();
    }
}
