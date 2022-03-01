using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject shootPrefab;
    public Vector3 offset;
    public AudioSource bulletSound;
    public AudioClip audioClip;
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
            

            bulletSound.clip = audioClip;
            bulletSound.Play();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, transform.position + new Vector3(-0.5f, -0.4f,0f)+offset,Quaternion.identity);
            Instantiate(shootPrefab, transform.position + offset, Quaternion.identity);
            Instantiate(shootPrefab, transform.position + new Vector3(0.5f, 0.4f, 0f)+offset, Quaternion.identity);
            bulletSound.clip = audioClip;
            bulletSound.Play();

        }
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
