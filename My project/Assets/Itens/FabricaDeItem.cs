using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaDeItem : MonoBehaviour
{
    [SerializeField] private Sprite[] ItemSprite;

    [SerializeField] private BoxCollider2D cd;
    [SerializeField] private GameObject ItemPrefab;
    [SerializeField] private float cooldown;
    private float timer;

    private int ItemFeito;
    private int ItemPontoReferência = 7;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = cooldown;
            ItemFeito++;

            if (ItemFeito > ItemPontoReferência && cooldown > .5f)
            {
                ItemPontoReferência += 7;
                cooldown -= .5f;

            }


            GameObject newItem = Instantiate(ItemPrefab);

            float randomX = Random.Range(cd.bounds.min.x, cd.bounds.max.x);

            newItem.transform.position = new Vector2(randomX, transform.position.y);

            int RandomIndex = Random.Range(0, ItemSprite.Length);
            newItem.GetComponent<SpriteRenderer>().sprite = ItemSprite[RandomIndex];

        }

    }
}
