using UnityEngine;

public class FurnaceScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Doc"))
        {
            //if Vision is Off: gain 1 point
            //else: lose 1 hp
            Destroy(collision.gameObject);
            
        }
    }
}
