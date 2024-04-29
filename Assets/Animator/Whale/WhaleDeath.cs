using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleDeath : MonoBehaviour
{
    public Animator animator;
    public GameObject ui;
    public ParticleSystem smoke;
    public AudioClip cannonShot;
    public AudioClip whaleGrowl;

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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void ShootCannon2()
    {
        smoke.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
        gameObject.GetComponent<AudioSource>().PlayOneShot(whaleGrowl);

    }

    public void Death()
    {
        animator.SetTrigger("Death");
    }

    public void PressYes()
    {
        HideUI();
        Death();
        ShootCannon2();

    }

    public void PressNo()
    {
        HideUI();

    }

}
