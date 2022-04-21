using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSpacecraftControllerButton : MonoBehaviour
{
    public GameObject player;
    public float speedRotation;
    public float speedMoveRightLeft;

    public bool inputButton;


   

    public virtual void Start()
    {
        player = GameObject.Find("Player");
        speedRotation = 0;
        speedMoveRightLeft = 14f;
    }

    public virtual void OnMouseDrag()
    {
    }

    public virtual void OnMouseUp()
    {
        inputButton = false;
    }

    public void MoveSpaceship(float posX, float rotZ)
    {
        Transform playerTransform = player.transform;
        Vector3 newPosPlayer = new Vector3(posX, playerTransform.position.y, playerTransform.position.z);
        playerTransform.rotation = Quaternion.Lerp(playerTransform.rotation, Quaternion.Euler(90, 0, rotZ), speedRotation * Time.deltaTime);
        playerTransform.position = Vector3.MoveTowards(playerTransform.position, newPosPlayer, speedMoveRightLeft * Time.deltaTime);
        inputButton = true;
    }
}
