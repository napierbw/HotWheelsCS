// @author: Benjamin Napier
// Controls the swapping between two the scenes of the app

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("yer");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("blah");
    }
}
