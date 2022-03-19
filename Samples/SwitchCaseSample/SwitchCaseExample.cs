using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedMoon.StateMachines;
using UnityEngine.Events;
using Bewildered;

public class SwitchCaseExample : MonoBehaviour
{
    public SwitchCaseStateMachine<string> SwitchStateMachine;

    public void ProcessCase(string @case)
    {
        SwitchStateMachine.ProcessCase(@case);
    }
}
