using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerButtons : MonoBehaviour
{

    private void OnMouseUpAsButton()
    {
        print("Вы нажали на " + gameObject.name + "2");
    }

}
