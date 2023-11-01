using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAudio : MonoBehaviour
{
    [SerializeField] private List<AudioSource> birdsAudio;

    private void Start()
    {
        if (birdsAudio.Count == 0) return;

        InvokeRepeating(nameof(PlayRandomBirdClip), 1f, Random.Range(3f, 6f));
    }
    private void PlayRandomBirdClip()
    {
        birdsAudio[Random.Range(0, birdsAudio.Count)].Play();
    }
}
