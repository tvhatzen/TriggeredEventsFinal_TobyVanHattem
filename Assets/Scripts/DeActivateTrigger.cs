using UnityEngine;

public class DeactivateOnTrigger : MonoBehaviour
{
    // Reference to the GameObject(s) to deactivate
    public GameObject[] objectsToDeactivate;

    // Flag to ensure that the deactivation happens only once
    private bool hasDeactivated = false;

    // This method is called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player and if deactivation hasn't already happened
        if (other.CompareTag("Player") && !hasDeactivated)
        {
            // Deactivate the specified objects
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }

            // Set the flag to true to prevent future deactivation
            hasDeactivated = true;

            // Optionally disable the collider to stop further trigger events
            // GetComponent<Collider>().enabled = false;
        }
    }
}