using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour4 : MonoBehaviour
{

    public GameObject ui;
    public ParticleSystem smoke;
    public AudioClip cannonShot;
    public AudioClip whaleGrowl;

    // Start is called before the first frame update
    void Start()
    {
        HideUI4();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUI4();
        }
    }

    public void HideUI4()
    {
        ui.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowUI4()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        //Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void ShootCannon4()
    {
        smoke.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
        gameObject.GetComponent<AudioSource>().PlayOneShot(whaleGrowl);

    }

    public void PressYes4()
    {
        HideUI4();
        ShootCannon4();
    }

    public void PressNo4()
    {
        HideUI4();
    }
}

