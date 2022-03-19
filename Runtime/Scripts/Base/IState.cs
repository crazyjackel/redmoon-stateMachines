using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedMoon.StateMachines
{
    public interface IState<TSelf, TCase, in TStateMachine>
        where TSelf : IState<TSelf, TCase, TStateMachine>
        where TStateMachine : IStateMachine<TStateMachine, TCase, TSelf>
    {
        void Process(TStateMachine @stateMachine);
    }
}
