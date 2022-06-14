using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void OnMouseDown()
    {
        Debug.Log("I'm a sphere!");
    }
}
