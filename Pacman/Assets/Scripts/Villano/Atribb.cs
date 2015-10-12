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
            if (PlayerPrefs.HasKey("Name1"))
            {
                if(Atributos.score>PlayerPrefs.GetInt("Score1"))
                {
                    PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                    PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                    PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                    PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                    PlayerPrefs.SetString("Name6", PlayerPrefs.GetString("Name5"));
                    PlayerPrefs.SetString("Name5", PlayerPrefs.GetString("Name4"));
                    PlayerPrefs.SetString("Name4", PlayerPrefs.GetString("Name3"));
                    PlayerPrefs.SetString("Name3", PlayerPrefs.GetString("Name2"));
                    PlayerPrefs.SetString("Name2", PlayerPrefs.GetString("Name1"));
                    PlayerPrefs.SetString("Name1", );
                }
            }
            Application.LoadLevel("HighScore");
        }
    }
}
