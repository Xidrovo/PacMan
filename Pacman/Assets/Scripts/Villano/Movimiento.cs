using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

    private Vector3 direccion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	    void FixedUpdate () 
    {
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            direccion = Vector3.up;
            transform.rotation = Quaternion.identity; // lo deja en la rotacion inicial
            this.GetComponent<Transform>().Rotate(Vector3.forward * 90);// rota a pacman en la direccion que va
        }
//        else if (Input.GetKey(KeyCode.DownArrow))
          else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            direccion = Vector3.down;
            transform.rotation = Quaternion.identity;
            this.GetComponent<Transform>().Rotate(Vector3.forward * -90);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direccion = Vector3.right;
            transform.rotation = Quaternion.identity;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direccion = Vector3.left;
            transform.rotation = Quaternion.identity;
            this.GetComponent<Transform>().Rotate(new Vector3(0,1,0) * 180);
        }
        transform.position += direccion * Atributos.Speed * Time.deltaTime;
    }
    
}

