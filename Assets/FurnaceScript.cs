using UnityEngine;

public class FurnaceScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool burningdoc=false;
    public float BurnTimerDefault = 1f;
    float actualTimer = 1f;
    ManagerScript managerScript;
    void Start()
    {
        managerScript = FindFirstObjectByType<ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //If a document is burning, start a countdown 
        if (burningdoc == true)
        {
            actualTimer -= Time.deltaTime;
        }

        //Once the countdown is finished, it is not burning, pausing the countdown and resetting the timer to default
        if (actualTimer <= 0f)
        {
            burningdoc = false;
            actualTimer = BurnTimerDefault;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Doc")) 
        {
            Destroy(collision.gameObject);
            burningdoc= true; //if you burn a document, it is starting to burn
            actualTimer = BurnTimerDefault; //If you burn a document, reset/refresh timer 
            managerScript.scoreTracker += 1;
        }
    }
}
