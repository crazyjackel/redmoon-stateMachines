using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RedMoon.StateMachines
{
    [Serializable]
    public class CallbackState<TCase, TStateMachine> : ICaseState<CallbackState<TCase,TStateMachine>, TCase, TStateMachine>
        where TStateMachine : IStateMachine<TStateMachine, TCase, CallbackState<TCase, TStateMachine>>
    {
        [SerializeField]
        private CallbackEvent<TStateMachine, TCase> m_action;

        public CallbackState(CallbackEvent<TStateMachine, TCase> action)
        {
            this.m_action = action;
        }

        public void Process(TStateMachine stateMachine)
        {
            m_action?.Invoke(stateMachine, default);
        }

        public void Process(TStateMachine stateMachine, TCase @case)
        {
            m_action?.Invoke(stateMachine, @case);
        }
    }
}