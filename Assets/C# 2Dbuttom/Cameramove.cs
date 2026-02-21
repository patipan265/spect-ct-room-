using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = transform.right * h + transform.forward * v;
        transform.position +=(move * speed * Time.deltaTime);
    }
}
