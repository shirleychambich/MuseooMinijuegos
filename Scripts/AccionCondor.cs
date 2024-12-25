using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AccionCondor : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody2D rb;
      private Vector2 moveInput;
  [SerializeField] private float velocidad = 1f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Update() {
        float moveX=Input.GetAxisRaw("Horizontal");
        float moveY=Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX,moveY).normalized;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
       rb.MovePosition(rb.position + moveInput*velocidad*Time.fixedDeltaTime);

    }
}
