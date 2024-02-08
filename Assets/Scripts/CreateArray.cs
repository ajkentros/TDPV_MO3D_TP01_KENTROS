using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArray : MonoBehaviour
{
    public GameObject blockPrefab;      // variable publica del tipo GameObject: prefab MyFirstPrefab
    public int N=3;       // variable privada entera: n�mero de bloques en el eje X
    public int M=4;       // variable privada entera: n�mero de bloques en el eje y

    private void Start()
    {
        
        // crea el muro de bloques recorriendo las filas (x) y las columnas (y)
        for (int y = 0; y < M; y++)
        {
            for (int x = 0; x < N; x++)
            {
                // calcular la posici�n del bloque toamndo la posici�n de x e y 
                Vector3 position = new(x * blockPrefab.transform.localScale.x, y * blockPrefab.transform.localScale.y, 0f);

                // instancia el bloque en la posici�n calculada
                GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);

                // agrega los bloques se agreguen como hijos de este objeto
                block.transform.parent = transform;
            }
        }
    }
}
