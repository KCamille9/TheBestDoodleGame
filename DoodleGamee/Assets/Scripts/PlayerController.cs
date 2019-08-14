using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;

    [SerializeField] Button moveButton;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(2, rb.velocity.y);
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-2, rb.velocity.y);
    }

    public void MoveUp()
    {
        Debug.Log("up btn pressed");
        //rb.AddForce(Vector2.up * 200);
        rb.velocity = Vector2.up * 8;
    }


}
