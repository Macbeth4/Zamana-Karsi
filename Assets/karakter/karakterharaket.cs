
using UnityEngine;

public class karakterharaket : MonoBehaviour
{
    Rigidbody2D rb;
    public static float yatayharaket;
    public int harakethızı;
    public int zıplamahızı;
    private int direction = 1; // başlangıçta sağa doğru gidiyoruz
    public bool isGrounded;
    public bool faceright = true;

    public GameManager managergame;

    Animator anim;

    AudioSource ses;
    public AudioClip yurume;
    public AudioClip ziplamasesi;
    public bool yuruyormu=false;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        ses = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(yatayharaket != 0){
            if(!ses.isPlaying){
                ses.Play();
            }
          } 
          else{ses.Stop();}
          
        //yatayharaket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayharaket * harakethızı , rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(yatayharaket));

        if(yatayharaket > 0 && faceright == false){
            turn();
        }
        if(yatayharaket < 0 && faceright == true){
            turn();
        }
        
        if(!isGrounded){anim.SetBool("isJump",true);}
        else if(isGrounded){anim.SetBool("isJump",false);}
        
    }

    public void sol(){
        yatayharaket = -1;
    }
    public void sağ(){
        yatayharaket = 1;
    }

    public void dur(){
        yatayharaket = 0;
    }
    public void zipla(){
        if(isGrounded == true){
            ses.PlayOneShot(ziplamasesi);
            rb.velocity = Vector2.up* zıplamahızı  ;
            isGrounded = false;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "zemin")
        {
            isGrounded = true;
        }
        if(other.gameObject.tag=="ölüm"){
            Time.timeScale = 0;
            yatayharaket = 0;
            managergame.buttonlar.SetActive(false);
            managergame.tekrardene.SetActive(true);
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "saat")
        {
            managergame._currenttime +=2;
            // Çarpışılan nesneyi yok et
            Destroy(other.gameObject);
        }
        
    }

    void turn()
    {
        faceright = !faceright;
        Vector2 yeniscale = transform.localScale;
        yeniscale.x *= -1;
        transform.localScale = yeniscale;
    }   
   
}