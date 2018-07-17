using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoint : MonoBehaviour {

    void OnTriggerEnter() {
        Destroy(gameObject);
        Score.pointUp += 1;
    }
	
}
