using UnityEngine;
using System.Collections.Generic;

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

    public List<Sprite> Normal;
    public List<Sprite> NormalStamped;
    int x;
    
    void Start()
    {
        //animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Normal.Add(Kakarot);
        Normal.Add(JohnSteward);
        Normal.Add(SelineHardy);
        Normal.Add(KeishaShark);
        Normal.Add(SusanTan);

        NormalStamped.Add(KakarotStamped);
        NormalStamped.Add(JohnStewardStamped);
        NormalStamped.Add(SelineHardyStamped);
        NormalStamped.Add(KeishaSharkStamped);
        NormalStamped.Add(SusanTanStamped);

        x=Random.Range(0,Normal.Count+1);

        spriteRenderer.sprite = Normal[x];
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //animator.Play("KakarotAnimationBurn");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stamp")) //if the object is a document
        {
            spriteRenderer.sprite = NormalStamped[x];
        }
    }
}
