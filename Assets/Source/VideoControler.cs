using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoControler : MonoBehaviour
{
    public float videoLength;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = videoLength;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= 1;
        if (currentTime == 1) {
            SceneManager.LoadScene("MenuState");
        }
    }
}
