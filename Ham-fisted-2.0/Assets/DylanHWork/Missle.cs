using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public GameObject ball;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            Destroy(ball);
        }
    }
}
