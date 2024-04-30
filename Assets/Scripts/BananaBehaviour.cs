using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaBehaviour : MonoBehaviour
{

    public GameObject ui;
    public Renderer BananaObject;
    public AudioClip bananaEatAudio;
    public ParticleSystem shine;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
        BananaObject = this.gameObject.GetComponent<MeshRenderer>();
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

    public void EatBanana()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(bananaEatAudio);

    }

    public void PressYes()
    {
        HideUI();
        EatBanana();
        shine.Stop();
        BananaObject.enabled = !BananaObject.enabled;
    }

    public void PressNo()
    {
        HideUI();

    }

}
