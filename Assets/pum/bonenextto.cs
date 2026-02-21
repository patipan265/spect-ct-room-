using UnityEngine;
using UnityEngine.SceneManagement;

public class bonenextto : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}

