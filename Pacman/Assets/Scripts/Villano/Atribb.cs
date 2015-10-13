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
            Destroy(other.gameObject);
            Atributos.muerto = true;
            Application.LoadLevel("HighScore");
        }
    }
}
