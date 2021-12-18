using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    private bool turnOn;
    public GameObject light1;
    public GameObject light2;
    void Start()
    {
        turnOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (turnOn && Input.GetMouseButtonUp(0))
        {
            light1.SetActive(!light1.activeSelf);
            light2.SetActive(!light2.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        turnOn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        turnOn = false;
    }
}
