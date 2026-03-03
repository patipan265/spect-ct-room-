using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playvideo :MonoBehaviour
    {
    private void Start()
    {
        var videoplayer = GetComponent<VideoPlayer>();
        videoplayer.Play();
    }
}
