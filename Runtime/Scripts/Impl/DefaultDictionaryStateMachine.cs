using Bewildered;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedMoon.StateMachines
{
    [Serializable]
    public class DefaultDictionaryStateMachine<TSelf, TCase, TState> : IStateMachine<TSelf, TCase, TState>
        where TState : IState<TState, TCase, TSelf>
        where TSelf : DefaultDictionaryStateMachine<TSelf, TCase, TState>
    {
        public TState m_default;
        [SerializeField]
        protected UDictionary<TCase, TState> caseStatePairs = new UDictionary<TCase, TState>();
        public DefaultDictionaryStateMachine(TState @default)
        {
            this.m_default = @default;
        }
        public void AddCase(TCase @case, TState @state)
        {
            caseStatePairs.Add(@case, @state);
        }
    }
}