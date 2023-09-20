using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    Rigidbody2D r2d;
    float strength = 5;
    float weight = 0.3f;
    float speed = 3;
    private void Awake()
    {
        r2d = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
  

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(input*speed*Time.deltaTime,0,0));
        if (Input.GetKeyDown(KeyCode.Space )) {
            r2d.AddForce(Vector2.up*strength,ForceMode2D.Impulse);
        
        }
        r2d.velocity = new Vector2(r2d.velocity.x, Mathf.Clamp(r2d.velocity.y, -3, 3));
        print(r2d.velocity.y);
    }

}
