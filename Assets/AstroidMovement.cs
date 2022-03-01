using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{
    public float AstroidSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * AstroidSpeed*Time.deltaTime);
        transform.Rotate(90.0f*AstroidSpeed*Time.deltaTime,0f,0f,Space.Self);
        if(transform.position.x<-12.0f)
        {
            Destroy(gameObject,3.0f);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="SpaceShip")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}
