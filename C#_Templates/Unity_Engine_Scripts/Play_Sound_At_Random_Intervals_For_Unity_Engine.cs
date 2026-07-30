/* Remeber to chat with AI to use this script if you faced any problems.
Important: Make sure to rename the file name to match the class name
to avoid compilation errors in Unity and vice versa. Unity requires that
the filename and class name match for MonoBehaviour scripts.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAtRandomIntervals : MonoBehaviour
{
    public float minSeconds = 5f; // Minimum interval to wait before playing sound.
    public float maxSeconds = 15f; // Maximum interval to wait before playing sound.

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlaySound());
    }

    private IEnumerator PlaySound()
    {
        while (true)
        {
            float waitTime = Random.Range(minSeconds, maxSeconds);
            yield return new WaitForSeconds(waitTime);
            audioSource.Play();
        }
    }
}