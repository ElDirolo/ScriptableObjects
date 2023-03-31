using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraductorManager : MonoBehaviour
{
    public static TraductorManager Instance;
    private AudioSource pronunciacion;
    public Text textoPrincipal;
    public Text Idioma;
    
    void Awake() 
    {
        Instance = this;
        pronunciacion = GetComponent<AudioSource>();
    }
    
    public void AddText(ScriptableObjects lengua)
    {
        textoPrincipal.text = lengua.traduccionIdioma;
        Idioma.text = "Idioma:" + lengua.idiomaName;
        pronunciacion.PlayOneShot(lengua.traductor);
    }
}
