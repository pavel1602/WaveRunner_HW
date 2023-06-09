using System;
using UnityEngine;

public class ScaleObstacle : MovingObstacle
{
    protected override Vector3 GetStartState(Vector3 maxDelta)
    {
        return transform.localScale - maxDelta;
    }
    protected override Vector3 GetEndState(Vector3 maxDelta)
    {
        return transform.localScale + maxDelta;
    }
    protected override void ApplyNewState(Vector3 newState)
    {
        transform.localScale = newState;
    }
}