using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject alga1;
    public GameObject alga2;
    public GameObject alga3;
    public GameObject alga4;
    public GameObject alga5;




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
        int algaNum = Random.Range(1,6);
  
        switch (algaNum)
        {
            case 1:
                {
                    GameObject alga = Instantiate(alga1, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    alga.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 2:
                {
                    GameObject alga = Instantiate(alga2, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    alga.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 3:
                {
                    GameObject alga = Instantiate(alga3, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    alga.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 4:
                {
                    GameObject alga = Instantiate(alga4, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    alga.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            case 5:
                {
                    GameObject alga = Instantiate(alga5, transform.position, Quaternion.identity);
                    //Para spanar os objetos com altura aleatoriamente a altura(y)
                    alga.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                    break;
                }
            default:
                {
                    
                    break;
                }
        }
    }

}
