using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3(1f, 0f, 0f);
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() 
    {
        Move();
    }
    // Update is called once per frame
    private void Move()
    {  
        transform.position += direction * speed * Time.deltaTime;
    }
}
