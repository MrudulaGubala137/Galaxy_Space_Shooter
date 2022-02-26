using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed, 0, 0);

        time=time+Time.deltaTime;
        if(time>3.0f)
        {
            Destroy(gameObject);
        }
    }
}
