using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollbar : MonoBehaviour
{

    public void ResizeCube(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * Vector3.one;
    }

    public void ChangePosY(float yPos)
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
