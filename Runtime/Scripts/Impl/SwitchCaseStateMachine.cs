using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedMoon.StateMachines
{
    [Serializable]
    public sealed class SwitchCaseStateMachine<TCase> : 
        DefaultDictionaryStateMachine<SwitchCaseStateMachine<TCase>, TCase, CallbackState<TCase, SwitchCaseStateMachine<TCase>>>,
        IStateProcessor<CallbackState<TCase, SwitchCaseStateMachine<TCase>>, TCase, SwitchCaseStateMachine<TCase>>
    {
        public SwitchCaseStateMachine(CallbackState<TCase, SwitchCaseStateMachine<TCase>> @default) : base(@default)
        {

        }

        public void ProcessCase(TCase @case)
        {
            if (caseStatePairs.ContainsKey(@case))
            {
                this.caseStatePairs[@case].Process(this);
            }
            else
            {
                m_default.Process(this);
            }
        }
    }
}

