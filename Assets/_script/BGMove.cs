using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Transform MainCamera;
    public Transform MidBG;
    public Transform SideBG;
    public float length;
    // Update is called once per frame
    void Update()
    {
        if (MainCamera.position.y > MidBG.position.y)
        {
            UpdateBackGroundPosition(Vector3.up);
        }
        else if(MainCamera.position.y < MidBG.position.y)
        {
            UpdateBackGroundPosition(Vector3.down);
        }
    }
    void UpdateBackGroundPosition(Vector3 direction)
    {
        SideBG.position = MidBG.position + direction * length;
        Transform temp = MidBG;
        MidBG = SideBG;
        SideBG = temp;
    }

}
