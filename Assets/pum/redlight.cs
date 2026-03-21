using UnityEngine;
using System.Collections;

public class redlight : MonoBehaviour

{
    public GameObject lightObject; 
    public float delayTime = 10f;  

    private bool isWorking = false; 

    // ฟังก์ชันนี้จะทำงานทันทีที่กด Play (เริ่มเกม)
    void Start()
    {
        if (lightObject != null)
        {
            lightObject.SetActive(false); // สั่งให้ไฟดับก่อนเสมอเมื่อเริ่มเกม
        }
    }

    void OnMouseDown()
    {
        // ถ้าไฟไม่ได้ทำงานอยู่ ให้เริ่มนับเวลาติด 10 วิ
        if (!isWorking && lightObject != null)
        {
            StartCoroutine(LightTimer());
        }
    }

    IEnumerator LightTimer()
    {
        isWorking = true;            
        lightObject.SetActive(true); // ไฟติด
        Debug.Log("Light ON for 10 seconds");

        yield return new WaitForSeconds(delayTime); // รอ 10 วินาที

        lightObject.SetActive(false); // ไฟดับ
        isWorking = false;           
        Debug.Log("Light OFF");
    }
}