using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicking : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponentInParent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.Play();
        Destroy(gameObject);
    }
}
