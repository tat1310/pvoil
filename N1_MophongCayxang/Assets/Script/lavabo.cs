using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavabo : MonoBehaviour
{
    private bool playerInZone;
    public GameObject nuoc;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInZone && Input.GetMouseButtonUp(0))
        {
            nuoc.SetActive(!nuoc.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerInZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerInZone = false;
    }
}
