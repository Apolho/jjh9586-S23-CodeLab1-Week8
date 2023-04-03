using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    
    public LocationScriptableObject currentLocation;
    public ObjectsScruptableObject currentObject;

    public Button location1Button;
    public Button location2Button;
    public Button location3Button;
    public TextMeshProUGUI location1TM;
    public TextMeshProUGUI location2TM;
    public TextMeshProUGUI location3TM;
    
    public Button search1;
    public Button search2;
    public TextMeshProUGUI search1TM;
    public TextMeshProUGUI search2TM;

    public Button back;
    
    
 

    // Start is called before the first frame update
    void Start()
    {
      UpdateLocation(); //will call update location function  
    }

   void UpdateLocation()
    {
       
        
            title.text = currentLocation.locationName; //will change title to the one in SO
            description.text = currentLocation.locationEnterDescription; //will change description to one in SO

            location1TM.text = currentLocation.location1.locationName; //changes button name to match the locations it will go to
            location2TM.text = currentLocation.location2.locationName;
            location3TM.text = currentLocation.location3.locationName;
            

            if (currentLocation.locationName != ("Plaza"))
            {
                location1Button.gameObject.SetActive(false); //deactivates buttons for locations
                location2Button.gameObject.SetActive(false);
                location3Button.gameObject.SetActive(false);
                
                search1.gameObject.SetActive(true); //activates buttons for objects
                search2.gameObject.SetActive(true);

                search1TM.text = currentLocation.object1.name; //changes button to match it
                search2TM.text = currentLocation.object2.name;
            }
           
        
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0: //location 1
                currentLocation = currentLocation.location1; //makes current location the one clicked in the button
                break;
            case 1: //location2
                currentLocation = currentLocation.location2;
                break;
            case 2: //location 3
                currentLocation = currentLocation.location3;
                break;
        }
      
        
        UpdateLocation(); //calls update location function
    }

    void Objects()
    {
        title.text = currentObject.objectName; //changes title text to the object name
        description.text = currentObject.objectDescription; //changes description text to the object description
        
        search2.gameObject.SetActive(false); //deactivates object buttons
        search1.gameObject.SetActive(false);
        
        back.gameObject.SetActive(true); //activates back button
    }

    public void Search(int obj)
    {
        switch (obj)
        {
            case 0:
                currentObject = currentLocation.object1; //makes current object the object button pressed
                break;
            case 1:
                currentObject = currentLocation.object2;
                break;
        }
        
        Objects(); //calls object function
    }

    public void Back()
    {
        title.text = currentLocation.locationName; 
        description.text = currentLocation.locationExitDescription;
        
        back.gameObject.SetActive(false); //deactivates back button
        
        location1Button.gameObject.SetActive(true);
        location2Button.gameObject.SetActive(true);
        location3Button.gameObject.SetActive(true);
    }
}
