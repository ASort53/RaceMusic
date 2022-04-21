using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSpacecraftRightButton : RotationSpacecraftControllerButton
{
    public const float POSPLAYERMAX = -6;
    public override void Start()
    {
        base.Start();
    }

    public override void OnMouseDrag()
    {
        print("Click Right Button");
        MoveSpaceship(-POSPLAYERMAX, -25);
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
    }
}
