using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    private float timeCounter;
    private float timeDisplay = 11;

    // Start is called before the first frame update
    void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        timeCounter = timeDisplay;
    }

    // Update is called once per frame
    void Update()
    {
        turnRed();
        turnYellow();
        turnGreen();
    }
    private void turnRed()
    {
        timeCounter -= Time.deltaTime;
        if(timeCounter > 8 && timeCounter <= 12)
        {
            light1.SetActive(true);
            light2.SetActive(false);
            light3.SetActive(false);
        }
    }
    private void turnYellow()
    {
        if (timeCounter > 4 && timeCounter <= 8)
        {
            light1.SetActive(false);
            light2.SetActive(true);
            light3.SetActive(false);
        }
    }
    private void turnGreen()
    {
        if (timeCounter > 0 && timeCounter <= 4)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(true);
        }
        else if (timeCounter < 0)
        {
            timeCounter = timeDisplay;
        }
    }
}
