using UnityEngine;

public class script_pcController : MonoBehaviour
{

    private Rigidbody2D pc;
    private Animator anim;
    private float velocidade, dirX;
    public static bool dir = true;
    private bool chao = true;

    void Start()
    {
        pc = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        velocidade = 7f;
    }

    public void Jump()
    {
        pc.velocity = Vector2.zero;
        pc.AddForce(new Vector2(0, 900));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "chao" || collision.gameObject.tag == "obstaculos")
        {
            chao = true;
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "chao" || collision.gameObject.tag == "obstaculos")
        {
            chao = false;
            transform.parent = null;
        }
    }
    
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        pc.velocity = new Vector2(dirX * velocidade, pc.velocity.y);

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && chao) {
            chao = false;
            pc.AddForce(new Vector2(0, 900));
        }

        if (dirX < 0 && dir || dirX > 0 && !dir)
        {
            transform.Rotate(new Vector2(0, 180));
            dir = !dir;
        }

        if (dirX == 0) {
            anim.SetBool("andando", false);
        } else {
            anim.SetBool("andando", true);
        }
    }
}
