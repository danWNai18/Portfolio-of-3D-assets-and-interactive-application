using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleDive : MonoBehaviour
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void Dive()
    {
        animator.SetTrigger("Dive");
    }

    public void PressYes()
    {
        HideUI();
        Dive();
    }

    public void PressNo()
    {
        HideUI();

    }

}
