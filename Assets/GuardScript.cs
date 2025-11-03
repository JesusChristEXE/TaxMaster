using JetBrains.Annotations;
using UnityEngine;

public class GuardScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    ManagerScript ManagerScript;
    FurnaceScript FurnaceScript;
    float GuardTimerActive = 15;
    float GuardTimerInactive = 10;

    public float minOnGuardTime =5;
    public float maxOnGuardTime =15;
    public float minOffGuardTime =5;
    public float maxOffGuardTime =10;

    SpriteRenderer spriteRenderer;
    public Sprite facingplayer;
    public Sprite sideview;
    public Sprite facingaway;
    

    public bool LookingAtPlayer= false;
    void Start()
    {
        ManagerScript = FindFirstObjectByType<ManagerScript>();
        FurnaceScript= FindFirstObjectByType<FurnaceScript>();
        GuardTimerActive = Random.Range(minOnGuardTime, maxOnGuardTime);
        GuardTimerInactive = Random.Range(minOffGuardTime, maxOffGuardTime);
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //while not looking at the player
        if (LookingAtPlayer == false) {
            GuardTimerInactive -= Time.deltaTime; //start counting down the inactive timer
            if (spriteRenderer.sprite != facingaway ||spriteRenderer.sprite!=sideview) {spriteRenderer.sprite = facingaway; } //if not facing away or side view, set it to facing away
        }

        if (LookingAtPlayer == true) //while looking at the player
        {   GuardTimerActive-= Time.deltaTime; //starts counting down the active timer
            if (spriteRenderer.sprite != facingplayer) { spriteRenderer.sprite = facingplayer; } //if not facing player, faces player
            if (FurnaceScript.burningdoc == true) //if a document is burning at this time, lose a life
            {   ManagerScript.lives -= 1;  
                FurnaceScript.burningdoc = false; //implemented so this code runs only once while the burning doc timer is going
                Debug.Log("Lost a life!");
            }

        }

        if (GuardTimerActive <= 0)//Once Guard's watch expires
        {
            LookingAtPlayer = false; //Guard is not looking at player
            GuardTimerActive = Random.Range(minOnGuardTime,maxOnGuardTime);//Reset the timer to be used again later while the other one ticks down
            Debug.Log("Guard is Idle for:" + GuardTimerInactive);
        } 

        if (GuardTimerInactive <= 0)  //Once Guard's Idle expires
        { 
            LookingAtPlayer= true;
            GuardTimerInactive = Random.Range(minOffGuardTime,maxOffGuardTime);//resets the timer to be used again later while the other one ticks down
            Debug.Log("Guard is Watching for:"+ GuardTimerActive);
        }
        if (GuardTimerInactive <= 5&& spriteRenderer.sprite!=sideview) { spriteRenderer.sprite = sideview; }
    }
}
