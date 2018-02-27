using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

    private string[] strMessages = new string[6];
    private TextMesh txmTextArea;

    private void Awake()
    {
        txmTextArea = this.GetComponent<TextMesh>();
    }

    private void Start()
    {
        for (int i = 0; i < strMessages.Length; i++)
        {
            if (i == 0)
            {
                strMessages[i] = "Bienvenido";
            }
            else if (i == 1)
            {
                strMessages[i] = "Para dirigirte a un punto o activar una acción, toca el botón de las gafas";
            }
            else if (i == 2)
            {
                strMessages[i] = "La Tecnología VR es demasiado innovadora y cada vez,";
            }
            else if (i == 3)
            {
                strMessages[i] = "mejora mucho más su posición en el mercado.";
            }
            else if (i == 4)
            {
                strMessages[i] = "Disfruta una de esas experiencias. ¡Adelante!";
            }
            else if (i == 5)
            {
                strMessages[i] = "Lunes 18 de Febrero de 2058";
            }

        }
        StartCoroutine(TextCoroutine());
    }

    private IEnumerator TextCoroutine()
    {
        for (int i = 0; i < strMessages.Length; i++)
        {
            txmTextArea.text = strMessages[i];
            if (i == 5)
            {
                txmTextArea.color = Color.green;
            }
            yield return new WaitForSeconds(6f);
        }
    }
}
