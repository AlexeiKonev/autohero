using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace autohero.old
{
    public class UIController : MonoBehaviour
    {

        public Slider healthSlider;
        //public Slider coinSlider;
        public Text coinText;

        public void UpdateHealth(float health)
        {
            healthSlider.value = health;
        }

        public void UpdateCoins(int coins)
        {
            //coinSlider.value = coins;
            coinText.text = "Coins: " + coins;
        }
    }
}
