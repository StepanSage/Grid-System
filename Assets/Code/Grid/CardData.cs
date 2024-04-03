using UnityEngine;

namespace Code.Grid
{
    [CreateAssetMenu(fileName ="New CardData" ,menuName = "Card Data")]
    public class CardData: ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _spriteCard; 

        public string ID => _id;
        public Sprite SpriteCard => _spriteCard;
    }
}
