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
        ManagerScript = FindFirstObjectByType<ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ManagerScript.lives != lives) { lives=ManagerScript.lives; }

    }
}
