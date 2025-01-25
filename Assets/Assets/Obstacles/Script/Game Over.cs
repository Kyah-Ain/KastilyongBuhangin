using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    public GameObject gameOverText;
    public GameObject gameOverButton;


    private GameObject player; // Store the player GameObject for resetting

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            TriggerGameOver(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            TriggerGameOver(other.gameObject);
        }
    }

    private void TriggerGameOver(GameObject player)
    {
        Debug.Log("Game Over!");
        this.player = player;

        // Activate the Game Over UI object
        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
            gameOverButton.SetActive(true);
        }
        else
        {
            Debug.LogError("Game Over UI object is not assigned!");
        }

        // Stop the player from moving and disable gravity
        Rigidbody2D playerRb = player.GetComponent<Rigidbody2D>();
        if (playerRb != null)
        {
            playerRb.velocity = Vector2.zero;
            playerRb.angularVelocity = 0f;
            playerRb.bodyType = RigidbodyType2D.Kinematic; // Disable gravity and physics forces
        }

        // Stop the rectangle from moving
        Rigidbody2D rectangleRb = GetComponent<Rigidbody2D>();
        if (rectangleRb != null)
        {
            rectangleRb.velocity = Vector2.zero;
            rectangleRb.angularVelocity = 0f;
        }
    }

    public void RetryGame()
    {
    
        Debug.Log("Retrying game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }
}