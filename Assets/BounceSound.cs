using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Rigidbody rigidbody;
    
    
    private void OnCollisionEnter()
    {
        audioSource.volume = rigidbody.velocity.magnitude / 10;
        audioSource.Play();
    }
}
