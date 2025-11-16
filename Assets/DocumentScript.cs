using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;

public class DocumentScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer spriteRenderer;
    Animator animator;
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
    public List<Sprite> DefaultStart;
    public List<Sprite> StampedDoc;
    private int X;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        DefaultStart.Add(Kakarot);
        DefaultStart.Add(JohnSteward);
        DefaultStart.Add(SelineHardy);
        DefaultStart.Add(KeishaShark);
        DefaultStart.Add(SusanTan);

        StampedDoc.Add(KakarotStamped);
        StampedDoc.Add(JohnStewardStamped);
        StampedDoc.Add(SelineHardyStamped);
        StampedDoc.Add(KeishaSharkStamped);
        StampedDoc.Add(SusanTanStamped);
        X = Random.Range(1, DefaultStart.Count + 1);
        spriteRenderer.sprite = DefaultStart[X];
            
    }

    // Update is called once per frame
    void Update()
    {
        //when stamped: 
        spriteRenderer.sprite = StampedDoc[X];
        if (X == 1) {animator.Play("KakarotAnimationBurn"); }
        
    }
}
