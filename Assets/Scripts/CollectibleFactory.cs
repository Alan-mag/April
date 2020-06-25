using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CollectibleFactory : Singleton<CollectibleFactory>
{
    [SerializeField] private Collectible[] availableCollectibles;
    [SerializeField] private PlayerController player;
    [SerializeField] private float waitTime = 180.0f;
    [SerializeField] private int startingCollectibles = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 50.0f;

    private List<Collectible> liveCollectibles = new List<Collectible>();
    private Collectible selectedCollectible;

    public List<Collectible> LiveCollectibles
    {
        get { return liveCollectibles; } 
    }

    public Collectible SelectedCollectible
    {
        get { return selectedCollectible; }
    }

    public void Awake()
    {
        Assert.IsNotNull(availableCollectibles);
        Assert.IsNotNull(player);
    }

    void Start()
    {
        for (int i = 0; i < startingCollectibles; i++)
        {
            InstantiateCollectible();
        }

        StartCoroutine(GenerateCollectibles());
    }

    private IEnumerator GenerateCollectibles()
    {
        while (true)
        {
            InstantiateCollectible();
            yield return new WaitForSeconds(waitTime);
        }
    }

    public void CollectibleWasSelected(Collectible collectible)
    {
        selectedCollectible = collectible;
    }

    private void InstantiateCollectible()
    {
        int index = Random.Range(0, availableCollectibles.Length);
        float x = player.transform.position.x + GenerateRange();
        float y = player.transform.position.y + 3.0f;
        float z = player.transform.position.z + GenerateRange();
        liveCollectibles.Add(Instantiate(availableCollectibles[index], new Vector3(x, y, z), Quaternion.identity));
    }

    private float GenerateRange()
    {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }
}
