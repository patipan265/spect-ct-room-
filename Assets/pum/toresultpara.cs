using UnityEngine;
using UnityEngine.SceneManagement;

public class toresultpara : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}