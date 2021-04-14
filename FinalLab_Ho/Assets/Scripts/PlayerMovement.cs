using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float bumpForce;

    private Rigidbody2D m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleTouchInput();
    }

    private void FixedUpdate()
    {
        
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                m_rb.velocity = Vector2.zero;
                m_rb.AddForce(Vector2.up * bumpForce, ForceMode2D.Force);
                Debug.Log("tap");
            }
        }
    }
}
