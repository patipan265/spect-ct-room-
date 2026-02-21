using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class pumupper3: MonoBehaviour
{
    public GameObject detectorup;
    public Vector3 targetPos;
    public float speed = 200f;
    public bool  detectorupclose;
void Update()
{
    if (detectorupclose)
    {
            detectorup.transform.position = Vector3.MoveTowards(detectorup.transform.position, 
                targetPos, speed * Time.deltaTime);
    }

}
void OnMouseDown()
{ 
        detectorupclose = true;
   
}

}

