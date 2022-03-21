using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliController : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
           transform.Translate(Vector3.down * speed * Time.fixedDeltaTime);
        }
    }
}
