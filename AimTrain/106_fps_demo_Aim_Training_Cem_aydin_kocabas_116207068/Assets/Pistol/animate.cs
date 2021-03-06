using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{
    public GameObject M9;
    public bool isfiring = false;
    public AudioSource PistolShot;
    public GameObject MuzzleFlash; 
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
        {
            if (isfiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    }
    IEnumerator FireThePistol()
    {
        isfiring = true;
        M9.GetComponent<Animator>().Play("Fire");
        PistolShot.Play();
        MuzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.10f);
        MuzzleFlash.SetActive(false);
        M9.GetComponent<Animator>().Play("New State");
        isfiring = false;
    }
}
