using UnityEngine;
using System.Collections;

public class MovimientoPacman : MonoBehaviour {

    public int DirA = 0;
    public int DirF = 0;

	// Use this for initialization
	void Start () {

        Atributos.Speed = 5;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            DirF = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            DirF = 2;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            DirF = 3;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            DirF = 4;
        }
        //if( && DriF>=3)///el pacman esta tocando un muro por arriba o por abajo
        //    ///colliders arriba y abajo entonces 
        //{
        //    DirA=DirF;
        //}
        //if( && DriF<=2)///el pacman esta tocando un muro por arriba o por abajo
        //    ///colliders izquier y derecha entonces 
        //{
        //    DirA=DirF;
        //}
        DirA = DirF;
        Debug.Log(DirA);
        switch(DirA)
        {
            case 1:
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * Atributos.Speed, ForceMode2D.Force);
                //this.transform.Translate(Vector3.up*Atributos.Speed*Time.deltaTime);
                break;
            }
            case 2:
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1) * Atributos.Speed, ForceMode2D.Force);
                //this.transform.Translate(Vector3.down*Atributos.Speed*Time.deltaTime);
                break;
            }
            case 3:
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0) * Atributos.Speed, ForceMode2D.Force);
                //this.transform.Translate(Vector3.right*Atributos.Speed*Time.deltaTime);
                break;
            }
            case 4:
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0) * Atributos.Speed, ForceMode2D.Force);
                //this.transform.Translate(Vector3.left*Atributos.Speed*Time.deltaTime);
                break;
            }

        }


	}
}
