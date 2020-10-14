using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActions : MonoBehaviour
{
    bool moveRB = false;
    bool moveEnter = false;
    bool rotateRB = false;
    bool rotateEnter = false;

    void Update()
    {
        if(moveRB && moveEnter) {
            MoveBoxRight();
        }
        if(rotateRB && rotateEnter) {
            RotateBoxRight();
        }

    }

    public void MoveBoxRightClickDown() {
        moveRB = true;
    }

    public void MoveBoxRightClickUp() {
        moveRB = false;
    }

    public void MoveBoxEnter() {
        moveEnter = true;
    }

    public void MoveBoxExit() {
        moveEnter = false;
    }

    public void MoveBoxRight() {
        transform.position += new Vector3(1f, 0f, 0f);
    }

    public void RotateBoxRightClickDown() {
        rotateRB = true;
    }

    public void RotateBoxRightClickUp() {
        rotateRB = false;
    }
    public void RotateBoxEnter() {
        rotateEnter = true;
    }

    public void RotateBoxExit() {
        rotateEnter = false;
    }

    public void RotateBoxRight() {
        transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
    }

    public void ChangeBoxColorRed() {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
