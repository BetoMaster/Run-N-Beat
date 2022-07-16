using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables p�blicas
    public Rigidbody2D rbody;
    public float speed;
    public float jumpForce;
    //public Transform pies;

    public Vector2 pies;
    public LayerMask layerPiso;
    public float radioColision;

    // Variables boleanas
    public bool enSuelo = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
        // SALTO
        // saltando();
       
        // MOVIMIENTO HACIA LA DERECHA
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, this.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnJump()
    {
        Debug.Log("Jump!");
        if (enSuelo == true)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        }
    }

    private void CheckGround()
    {
        enSuelo = Physics2D.OverlapCircle((Vector2)transform.position + pies, radioColision, layerPiso);
        //RaycastHit2D hit = Physics2D.Raycast(pies.position, Vector2.down, 0.5f);
        //Debug.DrawRay(pies.position, Vector2.down, Color.yellow, 0.5f);
        //if (hit.collider != null)
        //{
        //    enSuelo = true;
        //}
        //else
        //{
        //    enSuelo = false;
        //}
    }
}
