using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleDeath : MonoBehaviour
{
    public Animator animator;
    public GameObject ui;

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
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;

    }

    public void ShowUI()
    {
        ui.SetActive(true);
        //Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Death()
    {
        animator.SetTrigger("Death");
    }

    public void PressYes()
    {
        HideUI();
        Death();
    }

    public void PressNo()
    {
        HideUI();

    }

}
