using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public int isStarted = 0;

    public GameObject DashText;
    public GameObject music;
    AudioSource audioSource;

    void Start()
    {
        audioSource = music.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        isStarted = 1;
        audioSource.Play();
        DashText.GetComponent<BottomText>().ChangeText("Geoxor - Ephemeral");
        gameObject.SetActive(false);
    }
}
