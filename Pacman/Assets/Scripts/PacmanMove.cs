using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PacmanMove : MonoBehaviour {

    public int speed;
    public string personaje;
    public Text textoPuntaje;

    private int puntaje;
    //{"pacman", "superman", "ironman", "hulk", "flash", "daredevil", "batman", "aquaman" };

    private Vector3 direccion;

	// Use this for initialization
	void Start () {
        personaje = "pacman";
        speed = 5;
        puntaje = 0;
        direccion = new Vector3(0.0f, 0.0f, 0.0f);
        textoPuntaje.text = "Score: " + puntaje.ToString();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bloque") && this.personaje.Equals("hulk") )
        {
            Renderer rend = other.gameObject.GetComponent<Renderer>();
            rend.enabled = true;
            Collider2D coll = other.gameObject.GetComponent<Collider2D>();
            coll.isTrigger = true;
        }
        if (other.gameObject.CompareTag("Pastilla"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Punto"))
        {
            other.gameObject.SetActive(false);
            puntaje++;
            textoPuntaje.text = "Score: " + puntaje.ToString();
        }
    }

    void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            direccion = Vector3.up;
            transform.rotation = Quaternion.identity; // lo deja en la rotacion inicial
            this.GetComponent<Transform>().Rotate(Vector3.forward * 90);// rota a pacman en la direccion que va
        }
        else if (Input.GetKey(KeyCode.DownArrow))
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
        transform.position += direccion * speed * Time.deltaTime;
    }
    
}
