using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked!");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Left Button Released!");
        }
    }
}
