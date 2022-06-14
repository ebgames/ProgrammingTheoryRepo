using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public string sphereName { get; private set; }

    private void Start() 
    {
        sphereName = "Roundy";    
    }
    
    public override void OnMouseDown()
    {
        Debug.Log("My name is " + sphereName);
    }
}
