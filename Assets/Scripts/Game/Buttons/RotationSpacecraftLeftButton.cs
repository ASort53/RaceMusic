using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSpacecraftLeftButton : RotationSpacecraftControllerButton
{
    public const float POSPLAYERMAX = 6;
    public override void Start()
    {
        base.Start();
    }

    public override void OnMouseDrag()
    {
        print("Click Left Button");
        MoveSpaceship(-POSPLAYERMAX, 25);
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
    }
}
