using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//creates a menu option
[CreateAssetMenu(
    fileName = "New Location", //files will be called this as default
    menuName = "ScriptableObjects/Location", // creates new menu option, then an option for the menu option
    order = 0 //order of location in the scriptable object section
        
)]
public class LocationScriptableObject : ScriptableObject
{
    public string locationName;
    public string locationEnterDescription;
    public string locationExitDescription;

    public LocationScriptableObject location1;
    public LocationScriptableObject location2;
    public LocationScriptableObject location3;
    
    public ObjectsScruptableObject object1;
    public ObjectsScruptableObject object2;
}
