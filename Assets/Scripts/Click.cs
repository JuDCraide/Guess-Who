using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider != null) {                    
                    var go = hit.collider.gameObject.GetComponent<RotateScript>();
                    //Debug.Log(hit.collider.gameObject.GetComponent<Character>().name);
                    if (go != null) {
                        go.Rotate();
                    }
                }
            }
        }
    }
}