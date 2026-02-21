using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class pumlowbone : MonoBehaviour
{
    public GameObject pumlow;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool pumlowclose;
    void Update()
    {
        if (pumlowclose)
        {
            pumlow.transform.position = Vector3.MoveTowards(pumlow.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        pumlowclose = true;

    }

}