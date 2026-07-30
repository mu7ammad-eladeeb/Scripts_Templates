/* Remeber to chat with AI to use this script if you faced any problems.
Important: Make sure to rename the file name to match the class name
to avoid compilation errors in Unity and vice versa. Unity requires that
the filename and class name match for MonoBehaviour scripts.
*/
using UnityEngine;


public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;

    void Start()
    {
        // Get the Animator component attached to the same GameObject as this script
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player (or another specified object)
        if (other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
        {
            if (doorAnimator != null)
            {
                // Trigger the Door_Open animation
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}
