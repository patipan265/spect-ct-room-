using UnityEngine;
using UnityEngine.SceneManagement;

public class toresultbone : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}