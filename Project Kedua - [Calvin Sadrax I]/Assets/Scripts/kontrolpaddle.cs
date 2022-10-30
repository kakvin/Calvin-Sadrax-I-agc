using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolpaddle : MonoBehaviour{   
    public int speed;
    public KeyCode atas;
    public KeyCode bawah;
    private Rigidbody2D gerak;
    // Start is called before the first frame update
    void Start(){
        gerak = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update(){
        //Panggil fungsi :
        Movement(GetInput());
    }

    private Vector2 GetInput(){
        if(Input.GetKey(atas)){
            return Vector2.up * speed;
        }
        if(Input.GetKey(bawah)){
            return  Vector2.down * speed;
        } 
        return Vector2.zero;
    }

    private void Movement(Vector2 speed){
        gerak.velocity = speed;
    }

}
