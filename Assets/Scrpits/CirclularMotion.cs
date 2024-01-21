using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclularMotion : MonoBehaviour
{
    private Vector3 origin;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        origin = new Vector3(0, 13, 0);
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.position = origin + new Vector3(8, 0, 0) * Mathf.Sin(time) + new Vector3(0, 0, 8) * Mathf.Cos(Time.time);
    }
}
