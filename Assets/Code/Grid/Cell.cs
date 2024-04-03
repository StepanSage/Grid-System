using UnityEngine;

namespace Code.Grid
{
    public class Cell : MonoBehaviour
    {
        private string _id;

        public void SetSpriteCard(Sprite cardSprite) => transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cardSprite;
        public void SetID(string id) => _id = id; 

        public Sprite GetSpriteCard() => transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
        public string GetID() => _id;


    }
}