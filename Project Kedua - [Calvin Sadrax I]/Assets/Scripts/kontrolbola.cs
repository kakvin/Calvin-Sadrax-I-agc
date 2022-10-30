using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolbola : MonoBehaviour{
    public Vector2 speed;
    private Rigidbody2D gerak;

    // Start is called before the first frame update
    void Start(){
        gerak = GetComponent<Rigidbody2D>();
        gerak.velocity = speed;
    }

    // Update is called once per frame
    void Update(){
        
    }
}
