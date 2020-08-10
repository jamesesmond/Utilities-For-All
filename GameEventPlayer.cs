using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventPlayer : MonoBehaviour
{
    public List<GameEvent> gameEvents;

    public void PlayAll()
    {
        foreach(GameEvent ge in gameEvents)
        {
            ge.Raise();
        }
    }

    public void PlayOne(int index)
    {
        if(gameEvents.Count > index && index >= 0)
        {
            gameEvents[index].Raise();
        }
    }
}
