using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedMoon.StateMachines
{
    public interface ICaseState<TSelf, TCase, in TStateMachine> : IState<TSelf, TCase, TStateMachine>
        where TSelf : ICaseState<TSelf, TCase, TStateMachine>
        where TStateMachine : IStateMachine<TStateMachine, TCase, TSelf>
    {
        void Process(TStateMachine @stateMachine, TCase @case);
    }

}
