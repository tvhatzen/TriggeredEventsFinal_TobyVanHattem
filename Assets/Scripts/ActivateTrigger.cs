using UnityEngine;

public class ActivateOnceOnTriggerExit : MonoBehaviour
{
    // Reference to the GameObject(s) to activate
    public GameObject[] objectsToActivate;

    // Flag to ensure that the activation happens only once
    private bool hasActivated = false;

    // This method is called when another collider exits the trigger zone
    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is the player and if activation hasn't already happened
        if (other.CompareTag("Player") && !hasActivated)
        {
            // Activate the specified objects
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }

            // Set the flag to true to prevent future activation
            hasActivated = true;

            // Optionally disable the collider to stop further trigger events
            // GetComponent<Collider>().enabled = false;
        }
    }
}