using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public List<Camera> cameras;
    private int index;

    public void ChangeNextCamera()
    {
        index = (index + 1) % cameras.Count;
        for (int i = 0; i < cameras.Count; i++)
            cameras[i].enabled = i == index;
    }
}
