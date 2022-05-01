using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Idioma", menuName = "Nuevo Idioma")]
public class Idiomas : ScriptableObject
{
    [SerializeField] private string texto1;
    [SerializeField] private string texto2;
    [SerializeField] private string texto3;
    [SerializeField] private string texto4;

    public string Texto1 { get { return texto1; } }
    public string Texto2 { get { return texto2; } }
    public string Texto3 { get { return texto3; } }
    public string Texto4 { get { return texto4; } }
}
