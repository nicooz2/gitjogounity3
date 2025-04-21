using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaDeBombinha : MonoBehaviour
{
    [SerializeField] private Sprite[] ItemSprite2;

    [SerializeField] private BoxCollider2D cd2;
    [SerializeField] private GameObject ItemPrefab2;
    [SerializeField] private float cooldown2;
    private float timer2;

    private int BombinhaFeita;
    

    // Update is called once per frame
    void Update()
    {
        timer2 -= Time.deltaTime;
        
        if (timer2 < 0)
        {
            timer2 = cooldown2;
            BombinhaFeita++;

            GameObject newItem2 = Instantiate(ItemPrefab2);

            float randomX2 = Random.Range(cd2.bounds.min.x, cd2.bounds.max.x);

            newItem2.transform.position = new Vector2(randomX2, transform.position.y);

            int RandomIndex2 = Random.Range(0, ItemSprite2.Length);
            newItem2.GetComponent<SpriteRenderer>().sprite = ItemSprite2[RandomIndex2];

        }
    }
}
