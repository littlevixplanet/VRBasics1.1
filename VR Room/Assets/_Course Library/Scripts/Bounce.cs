using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public PlayQuickSound pq;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        pq = GetComponent<PlayQuickSound>();
        if(collision.gameObject.name == "Room_Modern_Floor")
        {
            pq.Play();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
