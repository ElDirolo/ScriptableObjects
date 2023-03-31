using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrasnlation : MonoBehaviour
{
    public ScriptableObjects lenguaje;

    public void Traduccion()
    {
        TraductorManager.Instance.AddText(lenguaje);
    }
}
