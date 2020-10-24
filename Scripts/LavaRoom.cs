using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRoom : MonoBehaviour
{
    public Handler Hndlr;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Hndlr.Respawn();
        }
    }
}
