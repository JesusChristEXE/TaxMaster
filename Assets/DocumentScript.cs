using UnityEngine;

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

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("KakarotAnimationBurn");
    }
}
