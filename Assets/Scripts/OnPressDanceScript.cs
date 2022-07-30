using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPressDanceScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] danceLights;
    [SerializeField]
    private Animator[] animasus;

    
    private void Update()
    {
        Dancer1();
        Dancer2();
        Dancer3();
        Dancer4();
        Dancer5();
        Dancer6();
        
    }

    private void Dancer1()
    {
        if (Input.GetKeyDown("1"))
        {
            danceLights[0].SetActive(true);
            animasus[0].SetBool("Dance1", true);
        }
        else if (Input.GetKeyUp("1"))
        {
            danceLights[0].SetActive(false);
            animasus[0].SetBool("Dance1", false);
        }
    }
    private void Dancer2()
    {
        if (Input.GetKeyDown("2"))
        {
            danceLights[1].SetActive(true);
            animasus[1].SetBool("Dance2", true);
        }
        else if (Input.GetKeyUp("2"))
        {
            danceLights[1].SetActive(false);
            animasus[1].SetBool("Dance2", false);
        }
    }
    private void Dancer3()
    {
        if (Input.GetKeyDown("3"))
        {
            danceLights[2].SetActive(true);
            animasus[2].SetBool("Dance3", true);
        }
        else if (Input.GetKeyUp("3"))
        {
            danceLights[2].SetActive(false);
            animasus[2].SetBool("Dance3", false);
        }
    }
    private void Dancer4()
    {
        if (Input.GetKeyDown("4"))
        {
            danceLights[3].SetActive(true);
            animasus[3].SetBool("Dance4", true);
        }
        else if (Input.GetKeyUp("4"))
        {
            danceLights[3].SetActive(false);
            animasus[3].SetBool("Dance4", false);
        }
    }
    private void Dancer5()
    {
        if (Input.GetKeyDown("5"))
        {
            danceLights[4].SetActive(true);
            animasus[4].SetBool("Dance5", true);
        }
        else if (Input.GetKeyUp("5"))
        {
            danceLights[4].SetActive(false);
            animasus[4].SetBool("Dance5", false);
        }
    }
    private void Dancer6()
    {
        if (Input.GetKeyDown("6"))
        {
            danceLights[5].SetActive(true);
            animasus[5].SetBool("Dance6", true);
        }
        else if (Input.GetKeyUp("6"))
        {
            danceLights[5].SetActive(false);
            animasus[5].SetBool("Dance6", false);
        }
    }
}
