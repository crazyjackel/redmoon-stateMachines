using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedMoon.StateMachines
{
    public interface IStateMachine<TSelf, in TCase, in TState>
            where TSelf : IStateMachine<TSelf, TCase, TState>
            where TState : IState<TState, TCase, TSelf>
    {
        void AddCase(TCase @case, TState @state);
    }
}
