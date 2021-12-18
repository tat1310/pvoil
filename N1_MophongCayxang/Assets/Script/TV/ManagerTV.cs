using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ManagerTV : MonoBehaviour
{
    public VideoClip video;
    public double time;
    public AudioSource speaker;
    public bool playerIsZone;
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.targetTexture.Release();
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, speaker);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsZone) {
            if (Input.GetMouseButtonUp(0)) { 
                if (!videoPlayer.isPlaying)
                {
                    PlayVideo();
                }
                else
                {
                    videoPlayer.Stop();
                    videoPlayer.targetTexture.Release();
                }
            }
        }
    }

    void PlayVideo()
    {
        videoPlayer.clip = video;
        videoPlayer.time = time;
        videoPlayer.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerIsZone = true;
    }
    private void OnTriggerExit(Collider other)
    {
        playerIsZone = false;
    }
}
