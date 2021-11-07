using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkHandeler : MonoBehaviour
{
    public void LoadURL(string url) {
        Application.OpenURL(url);
    }
}
