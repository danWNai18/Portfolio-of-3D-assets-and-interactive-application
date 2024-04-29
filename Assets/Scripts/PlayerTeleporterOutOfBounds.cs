using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporterOutOfBounds : MonoBehaviour
{
    public GameObject playerTeleporter;

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
            transform.position = new Vector3(-3, -2, 1);
        }
    }
}
