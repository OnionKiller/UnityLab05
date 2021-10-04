using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movespeed = 0.5f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void movePlayer(Vector3 direction)
    {
        if (direction.magnitude  == 0) {
            // Default state
            animator.SetInteger("PlayerAnimState", 0);
            return;
        }
        animator.SetInteger("PlayerAnimState", 1);
        transform.position = transform.position + direction;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Application.Quit();
        float dt = Time.deltaTime;
        Vector3 move = new Vector3(0,0,0);
        move[1] = Input.GetAxis("Vertical")*dt;
        move[0] = Input.GetAxis("Horizontal")*dt;
        movePlayer(move);
    }
}
