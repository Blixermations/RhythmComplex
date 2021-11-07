using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int StageHealth;
    public int StartHealth;
    // Start is called before the first frame update
    void Start()
    {
        StageHealth = StartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (StageHealth > StartHealth) {
            Debug.Log("StageHealth --> StartHealth");
        }
    }
}
