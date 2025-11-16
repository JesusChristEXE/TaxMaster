using UnityEngine;

public class BurningDocDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timer = .5f;
    Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if (timer < 0) { Destroy(gameObject); }
    }
}
