using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdiomaTextos : MonoBehaviour
{
    [SerializeField] Idiomas idioma;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public void CambioIdioma()
    {
        text1.text = idioma.Texto1;
        text2.text = idioma.Texto2;
        text3.text = idioma.Texto3;
        text4.text = idioma.Texto4;
    }

}
