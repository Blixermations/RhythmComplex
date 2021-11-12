using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playstate : MonoBehaviour
{
    public string whatLevel = "NULL";

    //vars for the charts.
    public GameObject levelTEST;
    private GameObject levelLOAD;

    void Start()
    {
        // ALRIGHT SO! FOR MY FUTURE SELF THIS IS HOW I IMPORTED AND USED THE CHARTS!
        // FIRST I MADE THEM IN UNITY / THE TEMPLATE CHART AND THEN TURNED THEM INTO PREFABS.
        // THEN I JUST INCLUDED THEM INSIDE THIS SCRIPT AS A PUBLIC METHOD. SO THEN I CAN ADD THEM IN THE 'maingame' SCENE.
        // AND THEN I JUST SEE WHAT LEVEL IS LOADING FROM THE MENUSELECT SCREEN, IF ITS NULL THEN LOAD THE TEST CHART.
        // RIGHT NOW THE CHARTS ARE IN DIFFRENT SCENES BUT ONCE IM DONE WITH THIS THEN I CAN DELETE THEM.
        // I HAVE ADDED THEM IN THE 'vars for the charts' COMMENT, SO ADD THEM THERE. BYE.

        if (whatLevel == "NULL") {
            levelLOAD = Instantiate(levelTEST);
            levelLOAD.transform.position = new Vector3(-0.02f, -0.69f, -9.99488f);
            levelLOAD.name = "CHART";
            
        }
        else {
            Debug.Log("WHAT THE HELL IS THIS CHART?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // this isnt needed but unity says it is so dont put anything into it.
    }
}
