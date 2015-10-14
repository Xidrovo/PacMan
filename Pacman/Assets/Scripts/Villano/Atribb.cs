using UnityEngine;
using System.Collections;

public class Atribb : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PacMan"))
        {
            if (PacmanMove.personaje.CompareTo("pacman") == 0)
            {
                Destroy(other.gameObject);
                Application.LoadLevel("HighScore");
            }
            
        }
        else if (!other.gameObject.CompareTag("Paredes"))
        {
            this.GetComponent<Collider2D>().isTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        this.GetComponent<Collider2D>().isTrigger = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            this.transform.position = new Vector3(0,0,0);
        }
    }
}
