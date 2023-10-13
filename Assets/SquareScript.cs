using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SquareScript : MonoBehaviour {
    public float speed = 1;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    private void FixedUpdate() {
        transform.Translate(Vector3.down * (Time.deltaTime * speed));
    }
}