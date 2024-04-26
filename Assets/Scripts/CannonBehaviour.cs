using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour
{

    public GameObject ui;
    public ParticleSystem smoke;
    public AudioClip cannonShot;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUI();
        }
    }

    public void HideUI() 
    {
        ui.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        //Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void ShootCannon()
    {
        smoke.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
    }

    public void PressYes()
    {
        HideUI();
        ShootCannon();
    }

    public void PressNo()
    {
        HideUI();
    }
}

