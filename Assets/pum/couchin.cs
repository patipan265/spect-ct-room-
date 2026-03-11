using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class couchin : MonoBehaviour
{
    public GameObject couch;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool couchisin;
    void Update()
    {
        if (couchisin)
        {
            couch.transform.position = Vector3.MoveTowards(couch.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        couchisin = true;

    }

}