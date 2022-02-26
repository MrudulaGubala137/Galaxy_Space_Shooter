using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject shootPrefab;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*speed*inputY*Time.deltaTime);
        transform.Translate(Vector3.right*speed*inputX*Time.deltaTime);

        if (transform.position.y>4.5f) 
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
        else if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }
        
        if (transform.position.x>7.0f)
        {
            transform.position = new Vector3(-7.0f,transform.position.y, 0);
        }
        else if(transform.position.x <- 7.0f)
        {
            transform.position = new Vector3(-7.0f, transform.position.y, 0);
        }
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(shootPrefab,transform.position+offset,Quaternion.identity);
        }
        

    }
}
