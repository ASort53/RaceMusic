using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : ControllerButtons
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("Game");
    }
}
