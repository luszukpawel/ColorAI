using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CSP : MonoBehaviour
{

    public Color DomainValues;
    public List<State> Positions = new List<State>();


    void Start()
    {
        Positions.Add(new State(0, new List<Vector2>
        {
            new Vector2(1f,1f),
            new Vector2(2f,0f),
            new Vector2(3f,1f),
        }));

        Positions.Add(new State(1, new List<Vector2>
        {
            new Vector2(0f,2f),
            new Vector2(2f,0f),
            new Vector2(3f,1f),
        }));
    }
}
