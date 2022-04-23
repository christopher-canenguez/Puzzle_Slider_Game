using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger!");
        if (collider.gameObject.CompareTag("Target"))
        {
            player.SetActive(false);
            
        }
            

    }
} // End class.
