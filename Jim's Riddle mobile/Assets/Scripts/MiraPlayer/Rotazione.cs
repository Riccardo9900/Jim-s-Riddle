using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotazione : MonoBehaviour
{
    public Joystick joystickSparo;

    /*Per la rotazione della mira: la mira ruota in base alla rotazione del joystick */
    void Update()
    {
        if (joystickSparo.Vertical < 0)
        {
            transform.eulerAngles = new Vector3(180, 0, joystickSparo.Horizontal * -90);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, joystickSparo.Horizontal * -90);
        }
    }
}
