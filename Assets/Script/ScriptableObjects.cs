using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Idioma", menuName = "Idioma")]
public class ScriptableObjects : ScriptableObject
{
    public string idiomaName;

    public string traduccionIdioma;
    
    public AudioClip traductor;
}
