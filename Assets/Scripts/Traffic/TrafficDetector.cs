using UnityEngine;
using System.Collections;

public class TrafficDetector : MonoBehaviour
{

    /*
    //Color[] colors = new Color[3];

    void Start()
    {
        colors[0] = Color.red;
        colors[1] = Color.yellow;
        colors[2] = Color.green;
        InvokeRepeating("colorChange", 0, 15f);
    }

    void colorChange()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.red, 2f);
        GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.yellow, 2f);
        GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.yellow, 2f);
        Debug.Log("OMG COLORS");
    }
    */
    public float speed = 0.5f;

    void Update()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.red, Mathf.PingPong(Time.time * speed, 1.0f));
     //   GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.yellow, 2f);
      //  GetComponent<Renderer>().material.color = Color.Lerp(Color.yellow, Color.green, 2f);
    }
}


