using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour2 : MonoBehaviour
{

    public GameObject ui;
    public ParticleSystem smoke;
    public AudioClip cannonShot;
    public AudioClip whaleGrowl;

    // Start is called before the first frame update
    void Start()
    {
        HideUI2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUI2();
        }
    }

    public void HideUI2()
    {
        ui.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowUI2()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        //Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void ShootCannon2()
    {
        smoke.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
        gameObject.GetComponent<AudioSource>().PlayOneShot(whaleGrowl);

    }

    public void PressYes2()
    {
        HideUI2();
        ShootCannon2();
    }

    public void PressNo2()
    {
        HideUI2();
    }
}

