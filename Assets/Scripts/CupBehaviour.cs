using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupBehaviour : MonoBehaviour
{

    public GameObject ui;
    public AudioClip cupDrinkAudio;
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

    public void DrinkFromCup()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(cupDrinkAudio);

    }

    public void PressYes()
    {
        HideUI();
        DrinkFromCup();
    }

    public void PressNo()
    {
        HideUI();

    }

}
