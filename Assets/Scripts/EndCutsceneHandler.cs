using UnityEngine;
using UnityEngine.Playables;

public class CutsceneHandler : MonoBehaviour
{
    public PlayableDirector playableDirector; // Reference to the PlayableDirector
    public GameObject canvasPanel; // Reference to the Canvas Panel

    void Start()
    {
        // Ensure the canvas panel is hidden initially
        if (canvasPanel != null)
            canvasPanel.SetActive(false);

        // Register the callback for when the timeline finishes
        if (playableDirector != null)
            playableDirector.stopped += OnTimelineFinished;
    }

    void OnDestroy()
    {
        // Unregister the callback to avoid memory leaks
        if (playableDirector != null)
            playableDirector.stopped -= OnTimelineFinished;
    }

    // Callback function for when the timeline finishes
    void OnTimelineFinished(PlayableDirector director)
    {
        // Activate the canvas panel
        if (director == playableDirector && canvasPanel != null)
        {
            canvasPanel.SetActive(true);
            Debug.Log("Canvas Panel Activated.");
        }
    }
}