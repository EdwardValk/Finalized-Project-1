using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGo : MonoBehaviour {

    float speed = 70.0f;

    // Initilization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
