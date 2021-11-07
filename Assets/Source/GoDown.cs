using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rb;

    // Update is called once per frame
    void Start()
    {
        Speed = Speed / 60;    // setting the speed down two a lower level, delete this if the game is on hard mode.
    }

    void Update()
    {
        transform.position -= new Vector3(0f, Speed * Time.deltaTime, 0f);
    }
}
