using TMPro;
using UnityEngine;
public class StoreItem : MonoBehaviour
{
    public int initialPrice = 0;

    public TextMeshProUGUI CostText;
    private float CostOfItem = 0;

    public TextMeshProUGUI AmountText;
    private int AmountOfItem = 0;


    private void Awake()
    {
        CostOfItem = initialPrice;
    }


    public void ItemPurchased()
    {
        CostOfItem = CostOfItem * 1.2f;
        AmountOfItem++;
        CostText.text = string.Format("${0:0.00}", CostOfItem);
        AmountText.text = AmountOfItem.ToString();

    }

}