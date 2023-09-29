using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private bool closed = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !closed) {
            closed = true;
            this.transform.Rotate(150, 0, 0); // 120 = 90 - 30
        } else if (Input.GetKeyDown(KeyCode.Space)) {
            closed = false;
            this.transform.Rotate(-150, 0, 0);
        }
    }

}
