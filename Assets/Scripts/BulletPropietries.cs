using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPropietries : MonoBehaviour
{
    public Vector3 direction = new Vector3(1f, 0f, 0f);
    public float speed = 3f;
    public int damage = 100;

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
