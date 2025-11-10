using UnityEngine;

public class CreateDocuments : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject document;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Instantiate(document, transform.position+ new Vector3(0,1,0), Quaternion.identity);
    }
}
