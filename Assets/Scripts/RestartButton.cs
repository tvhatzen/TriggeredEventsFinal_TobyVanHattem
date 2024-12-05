using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameOnSpace : MonoBehaviour
{
    [SerializeField] private GameObject canvasPanel; // Reference to the Canvas Panel

    void Update()
    {
        // Check if the spacebar is pressed and the panel is active
        if (canvasPanel != null && canvasPanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }

    // Method to restart the game
    private void RestartGame()
    {
        // Reload the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}