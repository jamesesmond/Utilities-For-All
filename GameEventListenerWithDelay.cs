using System.Collections;
using UnityEngine;


public class GameEventListenerWithDelay : GameEventListener
{
    public FloatVariable delay;

    public override void OnEventRaised()
    {
        StartCoroutine(AfterDelay());
    }

    private IEnumerator AfterDelay()
    {
        yield return new WaitForSeconds(delay.Value);

        Response.Invoke();
    }
}
