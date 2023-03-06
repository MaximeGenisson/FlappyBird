using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float flapyStrenght = 20f;
    public Logic logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
             birdBody.velocity = Vector2.up * flapyStrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        birdIsAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "gamspace"){
            logic.gameOver();
        birdIsAlive = false;
        }
    }

}
