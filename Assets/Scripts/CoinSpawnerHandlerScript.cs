using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawnerHandlerScript : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private int numberOfCoins;

    private Vector3 randomPosition;
    private RaycastHit hit;

    private void Start()
    {
        CoinSpawner();
    }

  

    private void CoinSpawner()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            {
                randomPosition = new Vector3(Random.Range(-48, 49), 1.0f, Random.Range(-45, 46));

                if (!IsPositionOccupied(randomPosition)) 
                {
                    Instantiate(coinPrefab, randomPosition, Quaternion.identity);
                }
               
            }
        }
    }

   

    private bool IsPositionOccupied(Vector3 position)
    {
        if (Physics.Raycast(position, Vector3.up, out hit, 2.0f))
        {
            return true;
        }

        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        CoinSpawner();
    }

   





}

