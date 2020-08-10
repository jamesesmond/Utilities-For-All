﻿using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEvent Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent Response;

    protected void OnEnable()
    {
        Event.RegisterListener(this);
    }

    protected void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public virtual void OnEventRaised()
    {
        Response.Invoke();
    }
}
