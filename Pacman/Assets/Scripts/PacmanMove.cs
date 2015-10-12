using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PacmanMove : MonoBehaviour {

    public static string personaje;
//    public RuntimeAnimatorController default1, flash, superman, hulk, daredevil,aquaman;
    public Text textoPuntaje;
    public AudioClip PacMan, AquaMan, BatMan, Hulk, Flash, DareDevil, SuperMan, IronMan;
    private Animator Anim;
    private int puntaje;
    //{"pacman", "superman", "ironman", "hulk", "flash", "daredevil", "batman", "aquaman" };

    private Vector3 direccion;

	// Use this for initialization
	void Start () {
        personaje = "pacman";
        puntaje = 0;
        direccion = new Vector3(0.0f, 0.0f, 0.0f);
        textoPuntaje.text = "Score: " + puntaje.ToString();
        InvokeRepeating("TiempoDePoder",0,1);
        direccion = Vector3.right;
        Anim = this.GetComponent<Animator>();
    }

    public void TiempoDePoder()
    {
        if (Atributos.PTime > 0)
        {
            Atributos.PTime--;
        }
        else 
        {
            //            this.GetComponent<Animator>().runtimeAnimatorController = default1;
            Anim.SetInteger("Estado", (int)Atributos.Estados.PACMAN);
            Atributos.PTime = 0;
            PacmanMove.personaje = "pacman";
            Atributos.Speed = 5;
        }
    }

    void OnTriggerEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pastilla"))
        {
            other.gameObject.SetActive(false);
            int prob=Random.Range(1, 8);
            switch (prob)
            {
                case 1:
                    {
                        PacmanMove.personaje = "flash";
                        Atributos.PTime = 3; 
                        Atributos.Speed *= 2.2f;
                        //this.GetComponent<Animator>().runtimeAnimatorController = flash;
                        Anim.SetInteger("Estado",(int) Atributos.Estados.FLASH);
                        this.GetComponent<AudioSource>().clip = Flash;
                        break;
                    }
                case 2:
                    {
                        Atributos.PTime = 2;
                        //this.GetComponent<Animator>().runtimeAnimatorController = hulk;
                        Anim.SetInteger("Estado", (int) Atributos.Estados.HULK);
                        PacmanMove.personaje = "hulk";
                        Atributos.Speed = 3;
                        this.GetComponent<AudioSource>().clip = Hulk;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
                case 3:
                    {
                        Atributos.PTime = 3;
                        Anim.SetInteger("Estado", (int) Atributos.Estados.AQUAMAN);
                        this.GetComponent<AudioSource>().clip = AquaMan;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
                case 4:
                    {
                        Atributos.PTime = 3;
                        Anim.SetInteger("Estado", (int)Atributos.Estados.BATMAN);
                        this.GetComponent<AudioSource>().clip = BatMan;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
                case 5:
                    {
                        Atributos.PTime = 3;
                        Anim.SetInteger("Estado", (int)Atributos.Estados.DAREDEVIL);
                        this.GetComponent<AudioSource>().clip = DareDevil;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
                case 6:
                    {
                        Atributos.PTime = 3;
                        Anim.SetInteger("Estado", (int)Atributos.Estados.IRONMAN);
                        this.GetComponent<AudioSource>().clip = IronMan;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
                case 7:
                    {
                        Atributos.PTime = 3;
                        Anim.SetInteger("Estado", (int)Atributos.Estados.SUPERMAN);
                        this.GetComponent<AudioSource>().clip = SuperMan;
                        this.GetComponent<AudioSource>().Play();
                        break;
                    }
            }
            
        }
        if (other.gameObject.CompareTag("Punto"))
        {
            other.gameObject.SetActive(false);
            puntaje++;
            textoPuntaje.text = "Score: " + puntaje.ToString();
        }
    }

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
