using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClick : MonoBehaviour
{
    public bool ClickedSpace;
    public bool Touching;
    public KeyCode PressThisKey;
    public GameObject Settings;

    // Start is used for setting values at the start :/
    void Start()
    {
        
    }

    // Update is the thing we want to use
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(PressThisKey)) {
            //Debug.Log("hold the key.");
            //StartCoroutine(ClickedSpaceAtTheMomenent());

        //}

        if (Input.GetKey(PressThisKey) && Touching) {
            Debug.Log("hold the key.");
            StartCoroutine(ClickedSpaceAtTheMomenent());
        }

        if (Input.GetKeyUp(PressThisKey)) {
            Debug.Log("UP");
        }
    }

    IEnumerator ClickedSpaceAtTheMomenent() {
        ClickedSpace = true;
        yield return new WaitForSecondsRealtime(0.01f);
        ClickedSpace = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Touching = true;
        if (ClickedSpace) {
            Debug.Log("pressed arrow!");
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Touching = false;
    }
}
