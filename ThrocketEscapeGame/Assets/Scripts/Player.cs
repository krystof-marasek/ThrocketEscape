using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject throwingObject;
    public Camera Camera;

    private Vector3 mousePosition;
    private Vector3 startPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(startPosition == Vector3.zero) {
                startPosition = throwingObject.transform.position;
            }
            
            PickUpObject();
        }

        if(Input.GetMouseButtonUp(0))
        {
            ThrowObject();
        }
    }

    private void PickUpObject()
    {
        // Get Mouse Position
        mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);
        throwingObject.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }

    private void ThrowObject()
    {
        Vector3 throwingDirection = mousePosition - startPosition;
        Debug.DrawRay(startPosition, throwingDirection, Color.red, 1f);
        throwingObject.GetComponent<Rigidbody2D>().AddForce(throwingDirection * 5, ForceMode2D.Impulse);
    }
}
