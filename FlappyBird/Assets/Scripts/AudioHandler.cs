using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;
    [SerializeField] private AudioClip _hit;
    [SerializeField] private AudioClip _point;
    [SerializeField] private AudioClip _wing;
    [SerializeField] private AudioClip _lose;


    public void PlayLose()
    {
        _audioSourse.PlayOneShot(_hit);
        _audioSourse.PlayOneShot(_lose);
    }


    public void PlayPoint()
    {
        _audioSourse.PlayOneShot(_point, 0.9f);
    }


    public void PlayWing()
    {
        _audioSourse.PlayOneShot(_wing);
    }
}
