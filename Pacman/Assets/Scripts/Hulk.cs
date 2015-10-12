using UnityEngine;
using System.Collections;

public class Hulk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bloque") && PacmanMove.personaje.Equals("hulk"))
        {
            SpriteRenderer Srend = other.gameObject.GetComponent<SpriteRenderer>();
            Srend.enabled = true;
            Collider2D coll = other.gameObject.GetComponent<Collider2D>();
            coll.isTrigger = true;
        }
    }
}
