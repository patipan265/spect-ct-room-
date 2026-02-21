using UnityEngine;
using UnityEngine.SceneManagement; 

public class nextto3 : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}

