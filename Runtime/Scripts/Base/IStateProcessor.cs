using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedMoon.StateMachines
{
    public interface IStateProcessor<in TState, TCase, TStateMachine> 
        where TState : IState<TState, TCase, TStateMachine>
        where TStateMachine : IStateMachine<TStateMachine, TCase, TState>
    {
        void ProcessCase(TCase @case);
    }
}
