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
    private void OnMouseDown() //on clicking this object's boxcollider
    {
        Instantiate(document, transform.position+ new Vector3(1,1,0), Quaternion.identity); 
        //create the document object, at 1 unit above the document pile's object, with regular rotation
    }
}
