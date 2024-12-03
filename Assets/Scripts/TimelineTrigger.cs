using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector;  // Reference to the PlayableDirector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player or an object is triggering the collider (you can adjust this condition)
        if (other.CompareTag("Player"))
        {
            // Play the Timeline when the player enters the trigger area
            if (playableDirector != null)
            {
                playableDirector.Play();
            }
            else
            {
                Debug.LogWarning("PlayableDirector is not assigned!");
            }
        }
    }
}