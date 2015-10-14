using UnityEngine;
using System.Collections;

public class Atribb : MonoBehaviour {

    public static float speedo;

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(9, 9);
        Atribb.speedo = 5;
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
            else //if (!other.gameObject.CompareTag("Paredes"))
            {
                this.GetComponent<Collider2D>().isTrigger = true;
            }
            
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
