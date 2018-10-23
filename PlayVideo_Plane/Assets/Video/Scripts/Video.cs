using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Video : MonoBehaviour
{
    public MovieTexture movie;
    private AudioSource audio;

    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
    }

    void OnMouseDown()
    {
        movie.Stop();
    }
}
