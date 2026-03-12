using UnityEngine;
using UnityEngine.SceneManagement;

public class torestart : MonoBehaviour
{

    public void gotorestart()
    {
        SceneManager.LoadScene("Restart");
    }


}