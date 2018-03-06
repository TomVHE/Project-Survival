using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;

    void Update() {
        CharMove();

    }

    void CharMove() {
        float forwardBack = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float leftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(leftRight, 0.0f, forwardBack);
    }
}
