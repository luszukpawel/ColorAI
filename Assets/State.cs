using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class State
{
    public int StateIndex;
    private List<Vector2> Coordinates;

    
    public State(int stateIndex,List<Vector2> coordinates)
    {
        StateIndex = stateIndex;
        Coordinates = coordinates;
    }
}
