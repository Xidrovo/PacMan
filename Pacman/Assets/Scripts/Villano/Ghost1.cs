﻿using UnityEngine;
using System.Collections;

public class Ghost1 : MonoBehaviour {

    private Vector3 direccion;
	// Use this for initialization
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direccion = Vector3.up;
            //transform.rotation = Quaternion.identity; // lo deja en la rotacion inicial
            //this.GetComponent<Transform>().Rotate(Vector3.forward * 90);// rota a pacman en la direccion que va
        }
        //        else if (Input.GetKey(KeyCode.DownArrow))
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            direccion = Vector3.down;
            //transform.rotation = Quaternion.identity;
            //this.GetComponent<Transform>().Rotate(Vector3.forward * -90);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direccion = Vector3.right;
            //transform.rotation = Quaternion.identity;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direccion = Vector3.left;
            //transform.rotation = Quaternion.identity;
            //this.GetComponent<Transform>().Rotate(new Vector3(0, 1, 0) * 180);
        }
        transform.position += direccion * Atribb.speedo * Time.deltaTime;
    }
}
