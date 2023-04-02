using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Location", //files will be called this as default
    menuName = "ScriptableObjects/Object", // creates new menu option, then an option for the menu option
    order = 1 //order of location in the scriptable object section
        
)]
public class ObjectsScruptableObject : ScriptableObject
{
    public string objectName;
    public string objectDescription;
}
