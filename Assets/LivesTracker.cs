using UnityEngine;
using UnityEngine.UI;

public class LivesTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image LifeImage;
    public int lives;
    ManagerScript ManagerScript;
    void Start()
    {
        ManagerScript = FindFirstObjectByType<ManagerScript>(); //find the manager's script to make changes
    }

    // Update is called once per frame
    void Update()
    {
        if (ManagerScript.lives != lives) { lives=ManagerScript.lives; } 
        //if the manager's lives do not match up with the lives displayed,
        //change the lives displayed to what the manager's script lives are

    }
}
