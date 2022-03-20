using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class CallbackEvent<TStateMachine, TCase> : UnityEvent<TStateMachine, TCase>
{

}
