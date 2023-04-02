using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cont : MonoBehaviour
{
    public TMP_Text text;

    public void Metodo()
    {
        text.text = PlayerPrefs.GetString("n1_scor");
    }
    
}
