using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public Text Name1, Name2, Name3, Name4, Name5, Name6, Name7, Name8, Name9, Name10, Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10;
    public InputField input;
    public GameObject panel;
	// Use this for initialization
	void Start () 
    {
        panel.SetActive(false);
        if (PlayerPrefs.HasKey("Score10") && (Atributos.score > PlayerPrefs.GetInt("Score10")) && Atributos.score != 0)
        {
            panel.SetActive(true);
        }
        ActualizarTexto();
	}
	
	// Update is called once per frame
	void Update () 
    {
	}

    public void ActualizarTexto()
    {
        Name1.text = PlayerPrefs.GetString("Name1");
        Name2.text = PlayerPrefs.GetString("Name2");
        Name3.text = PlayerPrefs.GetString("Name3");
        Name4.text = PlayerPrefs.GetString("Name4");
        Name5.text = PlayerPrefs.GetString("Name5");
        Name6.text = PlayerPrefs.GetString("Name6");
        Name7.text = PlayerPrefs.GetString("Name7");
        Name8.text = PlayerPrefs.GetString("Name8");
        Name9.text = PlayerPrefs.GetString("Name9");
        Name10.text = PlayerPrefs.GetString("Name10");
        Score1.text = "" + PlayerPrefs.GetInt("Score1");
        Score2.text = "" + PlayerPrefs.GetInt("Score2");
        Score3.text = "" + PlayerPrefs.GetInt("Score3");
        Score4.text = "" + PlayerPrefs.GetInt("Score4");
        Score5.text = "" + PlayerPrefs.GetInt("Score5");
        Score6.text = "" + PlayerPrefs.GetInt("Score6");
        Score7.text = "" + PlayerPrefs.GetInt("Score7");
        Score8.text = "" + PlayerPrefs.GetInt("Score8");
        Score9.text = "" + PlayerPrefs.GetInt("Score9");
        Score10.text = "" + PlayerPrefs.GetInt("Score10");
    }

    public void BaseDeDatos()
    {
        if (PlayerPrefs.HasKey("Name1"))
        {
            if (Atributos.score > PlayerPrefs.GetInt("Score1"))
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
                PlayerPrefs.SetString("Name1", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", PlayerPrefs.GetInt("Score5"));
                PlayerPrefs.SetInt("Score5", PlayerPrefs.GetInt("Score4"));
                PlayerPrefs.SetInt("Score4", PlayerPrefs.GetInt("Score3"));
                PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
                PlayerPrefs.SetInt("Score2", PlayerPrefs.GetInt("Score1"));
                PlayerPrefs.SetInt("Score1", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score2"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                PlayerPrefs.SetString("Name6", PlayerPrefs.GetString("Name5"));
                PlayerPrefs.SetString("Name5", PlayerPrefs.GetString("Name4"));
                PlayerPrefs.SetString("Name4", PlayerPrefs.GetString("Name3"));
                PlayerPrefs.SetString("Name3", PlayerPrefs.GetString("Name2"));
                PlayerPrefs.SetString("Name2", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", PlayerPrefs.GetInt("Score5"));
                PlayerPrefs.SetInt("Score5", PlayerPrefs.GetInt("Score4"));
                PlayerPrefs.SetInt("Score4", PlayerPrefs.GetInt("Score3"));
                PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
                PlayerPrefs.SetInt("Score2", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score3"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                PlayerPrefs.SetString("Name6", PlayerPrefs.GetString("Name5"));
                PlayerPrefs.SetString("Name5", PlayerPrefs.GetString("Name4"));
                PlayerPrefs.SetString("Name4", PlayerPrefs.GetString("Name3"));
                PlayerPrefs.SetString("Name3", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", PlayerPrefs.GetInt("Score5"));
                PlayerPrefs.SetInt("Score5", PlayerPrefs.GetInt("Score4"));
                PlayerPrefs.SetInt("Score4", PlayerPrefs.GetInt("Score3"));
                PlayerPrefs.SetInt("Score3", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score4"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                PlayerPrefs.SetString("Name6", PlayerPrefs.GetString("Name5"));
                PlayerPrefs.SetString("Name5", PlayerPrefs.GetString("Name4"));
                PlayerPrefs.SetString("Name4", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", PlayerPrefs.GetInt("Score5"));
                PlayerPrefs.SetInt("Score5", PlayerPrefs.GetInt("Score4"));
                PlayerPrefs.SetInt("Score4", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score5"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                PlayerPrefs.SetString("Name6", PlayerPrefs.GetString("Name5"));
                PlayerPrefs.SetString("Name5", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", PlayerPrefs.GetInt("Score5"));
                PlayerPrefs.SetInt("Score5", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score6"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", PlayerPrefs.GetString("Name6"));
                PlayerPrefs.SetString("Name6", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", PlayerPrefs.GetInt("Score6"));
                PlayerPrefs.SetInt("Score6", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score7"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", PlayerPrefs.GetString("Name7"));
                PlayerPrefs.SetString("Name7", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", PlayerPrefs.GetInt("Score7"));
                PlayerPrefs.SetInt("Score7", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score8"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", PlayerPrefs.GetString("Name8"));
                PlayerPrefs.SetString("Name8", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", PlayerPrefs.GetInt("Score8"));
                PlayerPrefs.SetInt("Score8", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score9"))
            {
                PlayerPrefs.SetString("Name10", PlayerPrefs.GetString("Name9"));
                PlayerPrefs.SetString("Name9", input.text);

                PlayerPrefs.SetInt("Score10", PlayerPrefs.GetInt("Score9"));
                PlayerPrefs.SetInt("Score9", Atributos.score);
            }
            else if (Atributos.score > PlayerPrefs.GetInt("Score10"))
            {
                PlayerPrefs.SetString("Name10", input.text);

                PlayerPrefs.SetInt("Score10", Atributos.score);
            }
            Atributos.score = 0;
        }
    }

    public void Aceptar()
    {
        panel.SetActive(false);
        BaseDeDatos();
        ActualizarTexto();
    }
    public void Cancel()
    {
        panel.SetActive(false);
    }
}
