using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class kanupper3 : MonoBehaviour
{
    public GameObject kanup;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool kanupclose;
    void Update()
    {
        if (kanupclose)
        {
            kanup.transform.position = Vector3.MoveTowards(kanup.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        kanupclose = true;

    }

}