using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static int pointUp = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Your score is: " + pointUp);
    }

}
