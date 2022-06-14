using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //INHERITANCE
{
    public string capName { get; private set; } // ENCAPSULATION

    private void Start() 
    {
        capName = "Cappy";    
    }
     public override void OnMouseDown() // POLYMORPHISM  // ABSTRACTION
    {
        Debug.Log("My name is " + capName);
    }
}
