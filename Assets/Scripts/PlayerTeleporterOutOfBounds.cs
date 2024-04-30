using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporterOutOfBounds : MonoBehaviour
{

    public CharacterController player;
    public Transform teleportPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.enabled = false; 
            other.transform.position = teleportPoint.position;
            player.enabled = true;
            print("collided");
        }
        print("helpehlpe");

    }
}
