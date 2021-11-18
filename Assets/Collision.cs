using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ah Fuck!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGERDDDD..!");
    }
}
