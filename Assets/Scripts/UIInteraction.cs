using UnityEngine;

internal class UIInteraction : MonoBehaviour
{
    public GameObject menuTransform;
    public GameObject createPricemenu1;
    public GameObject createPricemenu2;
    public GameObject editPrice;
    public GameObject addPrice;

    public void GoToCreatePricesPage()
    {
        menuTransform.SetActive(false);
        createPricemenu1.SetActive(true);
    }

    public void GoToEditProductPage()
    {
        menuTransform.SetActive(false);
        editPrice.SetActive(true);
    }

    public void GoToAddProductPage()
    {
        menuTransform.SetActive(false);
        addPrice.SetActive(true);
    }

    public void BackToMenu()
    {
        createPricemenu1.SetActive(false);
        //createPricemenu2.SetActive(false);
        //editPrice.SetActive(false);
        //addPrice.SetActive(false);
        menuTransform.SetActive(true);
    }
}
