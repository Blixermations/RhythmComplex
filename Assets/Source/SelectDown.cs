using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectDown : MonoBehaviour
{
    public TextMeshPro freeplayFocus;
    public TextMeshPro settingsFocus;
    private string focusType = "null";
    //public Sprite freeplayUnFocus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (focusType == "settings") {
                focusType = "freeplay";
                freeplayFocus.color = Color.white;
                settingsFocus.color = Color.gray;
            }
            else if(focusType == "freeplay") {
                focusType = "settings";
                settingsFocus.color = Color.white;
                freeplayFocus.color = Color.gray;
            }
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter)) {
            Debug.Log("PRESSED ENTER ON MENU ITEM.");
        }
    }
}
