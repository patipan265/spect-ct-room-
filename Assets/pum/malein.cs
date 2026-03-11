using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class malein : MonoBehaviour
{
    public GameObject male01_3;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool maleisin;
    void Update()
    {
        if (maleisin)
        {
            male01_3.transform.position = Vector3.MoveTowards(male01_3.transform.position,
                targetPos, speed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {
        maleisin = true;

    }

}