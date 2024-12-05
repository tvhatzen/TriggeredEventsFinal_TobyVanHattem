using UnityEngine;

public class DeactivateMeshOnTrigger : MonoBehaviour
{
    // Reference to the object's MeshRenderer
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Get the MeshRenderer component
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Trigger event when something enters the collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the collider is the player
        if (other.CompareTag("Player"))
        {
            // Deactivate the mesh renderer
            if (meshRenderer != null)
            {
                meshRenderer.enabled = false;
            }
        }
    }
}