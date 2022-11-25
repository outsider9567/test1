using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Floor1"){
            Debug.Log("撞到方塊一");
        }
        else if(other.gameObject.tag == "Floor2"){
            Debug.Log("撞到方塊二");
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "DeathLine"){
            Debug.Log("你已經死了");
        }    
    }
}
