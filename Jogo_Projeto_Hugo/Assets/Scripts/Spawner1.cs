using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject peixes1;
    public GameObject peixes2;
    public GameObject peixes3;
    public GameObject peixes4;
    public GameObject peixes5;
    public GameObject peixes6;


    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 2f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {

        //cria um numero aleatorio para escolher um dos objetos criados
        int peixesNum = Random.Range(1, 7);

        switch (peixesNum)
        {
            case 1:
                {
                    GameObject peixe = Instantiate(peixes1, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 2:
                {
                    GameObject peixe = Instantiate(peixes2, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 3:
                {
                    GameObject peixe = Instantiate(peixes3, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 4:
                {
                    GameObject peixe = Instantiate(peixes4, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 5:
                {
                    GameObject peixe = Instantiate(peixes5, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 6:
                {
                    GameObject peixe = Instantiate(peixes6, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    peixe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            default:
                {

                    break;
                }
        }
    }

}