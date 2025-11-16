using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;

public class DocumentScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    SpriteRenderer spriteRenderer;
    //Animator animator;
    public Sprite Kakarot;
    public Sprite KakarotStamped;

    public Sprite JohnSteward;
    public Sprite JohnStewardStamped;

    public Sprite SelineHardy;
    public Sprite SelineHardyStamped;

    public Sprite KeishaShark;
    public Sprite KeishaSharkStamped;

    public Sprite SusanTan;
    public Sprite SusanTanStamped;

    public Sprite Homeless;
    public Sprite HomelessStamped;

    public List<Sprite> Normal;
    public List<Sprite> NormalStamped;
    int x;
    public float docburntimer = 1;

    public GameObject KakarotBurn;
    public GameObject JohnStewardBurn;
    public GameObject SelineHardyBurn;
    public GameObject KeishaSharkBurn;
    public GameObject SusanTanBurn;
    public GameObject HomelessBurn;
    
    void Start()
    {
        //animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        //add the regular sprites to the normal, default list of sprites
        Normal.Add(Kakarot);
        Normal.Add(JohnSteward);
        Normal.Add(SelineHardy);
        Normal.Add(KeishaShark);
        Normal.Add(SusanTan);
        Normal.Add(Homeless);

        //add the stamped sprites onto the stamped sprite list
        NormalStamped.Add(KakarotStamped);
        NormalStamped.Add(JohnStewardStamped);
        NormalStamped.Add(SelineHardyStamped);
        NormalStamped.Add(KeishaSharkStamped);
        NormalStamped.Add(SusanTanStamped);
        NormalStamped.Add(HomelessStamped);

        //random number generator selecting which item in the list to implement
        x=Random.Range(0,Normal.Count);
        spriteRenderer.sprite = Normal[x];
    }

    // Update is called once per frame
    void Update()
    {
        
        //animator.Play("KakarotAnimationBurn");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stamp")) //if the object collided is a stamp
        {
            spriteRenderer.sprite = NormalStamped[x]; //set it to be the Xth sprite on the stamped list
        }
        if (collision.gameObject.CompareTag("Furnace"))
        {
            //depending on which number on the list it is in, create an object that plays this animation
            //(the object should be destoryed after anumation is done)
            if (x == 0) { Instantiate(KakarotBurn,transform.position,Quaternion.identity); }
            else if (x == 1) { Instantiate(JohnStewardBurn, transform.position, Quaternion.identity); }
            else if (x == 2) { Instantiate(SelineHardyBurn, transform.position, Quaternion.identity); }
            else if (x == 3) { Instantiate(KeishaSharkBurn, transform.position, Quaternion.identity); }
            else if (x == 4) { Instantiate(SusanTanBurn, transform.position, Quaternion.identity); }
            else { Instantiate(HomelessBurn, transform.position, Quaternion.identity); }
            Destroy(gameObject);
        }
    }
}
