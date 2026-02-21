using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class pumupbone : MonoBehaviour
{
    public GameObject pumup;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool pumupclose;
    void Update()
    {
        if (pumupclose)
        {
            pumup.transform.position = Vector3.MoveTowards(pumup.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        pumupclose = true;

    }

}