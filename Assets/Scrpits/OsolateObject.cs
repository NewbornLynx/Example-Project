using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsolateObject : MonoBehaviour
{
    private Vector3 direction;
    private Vector3 origin;
    private float time;
    [SerializeField]private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(1, 0, 0);
        origin = new Vector3(0, 20, 10);
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += direction * Time.deltaTime;
        //transform.eulerAngles += new Vector3(1, 0, 0) * 3f * Time.deltaTime;
        time += Time.deltaTime;
        //transform.position = origin + new Vector3(5, 0, 0) * Mathf.Sin(time) + new Vector3(0, 5, 0) * Mathf.Cos(Time.time);
        transform.position = origin + new Vector3(5, 0, 0) * Mathf.Sin(Time.time * speed);
    }
}
