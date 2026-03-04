using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 3.5f;
    public float gravity = -9.81f; // เพิ่มบรรทัดนี้: กำหนดค่าแรงโน้มถ่วง
    
    [Header("Mouse Look Settings")]
    public float mouseSensitivity = 200f;
    public Transform playerCamera;

    // Internal Variables
    float xRotation = 0f;
    float yVelocity; // เพิ่มบรรทัดนี้: สำหรับเก็บค่าความเร็วในแนวแกน Y (แรงโน้มถ่วง)
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        
        // ล็อคเมาส์ไว้กลางจอ
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // -------- Mouse Look --------
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        // -------- Movement --------
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // คำนวณทิศทางการเดินตามหน้าของตัวละคร
        Vector3 move = transform.right * x + transform.forward * z;

        // -------- Gravity (จัดการแรงโน้มถ่วง) --------
        // เช็คว่าตัวละครอยู่บนพื้นหรือไม่
        if (controller.isGrounded && yVelocity < 0)
        {
            yVelocity = -2f; // กดตัวละครไว้กับพื้นเล็กน้อยเพื่อป้องกันอาการสั่น
        }

        // คำนวณแรงโน้มถ่วงสะสม
        yVelocity += gravity * Time.deltaTime;
        
        // นำค่าแรงโน้มถ่วงไปใส่ในแนวแกน y ของ vector การเคลื่อนที่
        move.y = yVelocity;

        // สั่งให้ CharacterController เคลื่อนที่
        controller.Move(move * speed * Time.deltaTime);
    }
}