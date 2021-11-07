using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuSelect : MonoBehaviour
{
    public bool isPressingEnter;
    private string ver = "1.0";
    private string buildVer = "3";
    public TextMeshProUGUI versionTag;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("RESET: MenuSelect.cs");
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressingEnter == true) {
            if (Input.GetKeyDown(KeyCode.Return)) {
                Debug.Log("MENUSTATE: Changed scene to MenuSelection.");
                ChangeScene("MenuSelection");
            }
        }

        versionTag.text = "RhythmComplex Version " + ver + " | Engine Version: " + buildVer;
    }

    public void ChangeScene(string scene) {
        SceneManager.LoadScene(scene);
    }
}
