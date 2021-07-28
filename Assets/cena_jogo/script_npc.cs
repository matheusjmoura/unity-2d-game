using UnityEngine;
using UnityEngine.SceneManagement;

public class script_npc : MonoBehaviour
{

    public float velocidade = -8;
    private Rigidbody2D rbd;
    private Collider2D col;
    private Animator anim;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        rbd.velocity = new Vector2(velocidade, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obstaculos")
        {
            velocidade = velocidade * -1;
            rbd.velocity = new Vector2(velocidade, 0);
            transform.Rotate(new Vector2(0, 180));
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;

        if (collision.gameObject.tag == "Player" && normal.y < 0)
        {
            rbd.velocity = new Vector2(0, 0);
            col.enabled = false;
            anim.SetBool("morto", true);
            collision.otherRigidbody.GetComponent<script_pcController>().Jump();
        } else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
