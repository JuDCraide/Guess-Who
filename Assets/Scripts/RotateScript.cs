using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour {
    private bool closed = false;

    public void Rotate() {
        if (!closed) {
            closed = true;
            this.transform.Rotate(150, 0, 0);
        }
        else {
            closed = false;
            this.transform.Rotate(-150, 0, 0);
        }
        Animal.UpdateOpenAnimalList(this.GetComponent<Animal>().id, closed);
    }

}

