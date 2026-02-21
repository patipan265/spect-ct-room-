using UnityEngine;
using UnityEngine.SceneManagement;

public class toresultrenal : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}