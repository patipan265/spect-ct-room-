using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class kanlowbone : MonoBehaviour
{
    public GameObject kanlow;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool kanlowclose;
    void Update()
    {
        if (kanlowclose)
        {
            kanlow.transform.position = Vector3.MoveTowards(kanlow.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        kanlowclose = true;

    }

}