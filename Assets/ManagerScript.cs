using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int lives = 2;
    
    public int scoreTracker=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (lives <= 0) { 
            Debug.Log("You lose");
            //Transition to Game Over scene
            SceneManager.LoadScene("GameOverScene");
        }

    }
}
