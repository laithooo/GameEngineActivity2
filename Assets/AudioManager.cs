using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; } //used ai for this in order to reduce time creating an audio manager

    [SerializeField] private AudioSource _audioSource; 

    private void Awake()
    {
        
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject); 
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject); 

        
        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
            if (_audioSource == null)
            {
                Debug.LogError("AudioManager requires an AudioSource component.");
            }
        }
    }

    public void PlaySoundEffect(AudioClip audioClip)
    {
        if (_audioSource != null && audioClip != null)
        {
            _audioSource.PlayOneShot(audioClip);
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip is missing.");
        }
    }

  
}