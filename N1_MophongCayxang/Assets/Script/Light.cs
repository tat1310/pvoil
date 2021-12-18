using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

    private bool PlayerinZone;
    public GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        PlayerinZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerinZone && Input.GetMouseButtonUp(0))
        {
            lights.SetActive(!lights.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            PlayerinZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
            PlayerinZone = false;
    }
}
