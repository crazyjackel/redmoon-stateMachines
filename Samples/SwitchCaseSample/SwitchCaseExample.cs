using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedMoon.StateMachines;
using UnityEngine.Events;
using Bewildered;

public class SwitchCaseExample : MonoBehaviour
{
    public string startingCase;
    public SwitchCaseStateMachine<string> SwitchStateMachine;

    public void Start()
    {
        SwitchStateMachine.ProcessCase(startingCase);
    }


    public void ProcessCase(string @case)
    {
        SwitchStateMachine.ProcessCase(@case);
    }

    public void DebugStr(string @debug)
    {
        Debug.Log(debug);
    }
}
