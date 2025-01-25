using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    // Tag to identify the player object
    [SerializeField] private string playerTag = "Player";
    // Points awarded when passing through the scoring zone
    [SerializeField] private int pointsPerZone = 1;
    // Current score
    private int score = 0;

    // Reference to a UI element or console output to display the score (optional)
    [SerializeField] private UnityEngine.UI.Text scoreText;

    private void Start()
    {
        // Initialize the score display if applicable
        UpdateScoreUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Block the player from passing if they hit a blocking collider
        if (collision.gameObject.CompareTag(playerTag))
        {
            Debug.Log("Player blocked!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Award points when the player passes through a scoring zone
        if (other.CompareTag(playerTag))
        {
            AddScore(pointsPerZone);
        }
    }

    private void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
