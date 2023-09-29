using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour {
    private bool closed = false;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public void Rotate() {
        if (!closed) {
            closed = true;
            this.transform.Rotate(150, 0, 0); // 120 = 90 - 30
        }
        else {
            closed = false;
            this.transform.Rotate(-150, 0, 0);
        }
    }

}

