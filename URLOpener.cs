// @author: Benjamin Napier
// Open the 360 view of the car interior

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL("https://www.carmax.com/car/17983619");
    }
}
