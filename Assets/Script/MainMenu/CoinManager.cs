using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{

    public int Coins;
    public Text CantBuy;
    public Image RCR1;
    public Image RCR2;
    public Image RCR3;
    public Image RCG1;
    public Image RCG2;
    public Image RCG3;
    public Image RCP1;
    public Image RCP2;
    public Image RCP3;
    public Image RCOV;


    // Use this for initialization
    void Start()
    {

        Coins = PlayerPrefs.GetInt("Coins", 0);
        

    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetInt("Coins", Coins);
        PlayerPrefs.Save();
        //red
        if (PlayerPrefs.GetInt("RU1") == 1)
        {
            RCR1.enabled = true;
        } else
        {
            RCR1.enabled = false;
        }

        if (PlayerPrefs.GetInt("RU2") == 1)
        {
            RCR2.enabled = true;
        } else
        {
            RCR2.enabled = false;
        }

        if (PlayerPrefs.GetInt("RU3") == 1)
        {
            RCR3.enabled = true;
        } else
        {
            RCR3.enabled = false;
        }
        //Green
        if (PlayerPrefs.GetInt("GU1") == 1)
        {
            RCG1.enabled = true;
        } else
        {
            RCG1.enabled = false;
        }
        if (PlayerPrefs.GetInt("GU2") == 1)
        {
            RCG2.enabled = true;
        } else
        {
            RCG2.enabled = false;
        }
        if (PlayerPrefs.GetInt("GU3") == 1)
        {
            RCG3.enabled = true;
        } else
        {
            RCG3.enabled = false;
        }
        //Purple
        if (PlayerPrefs.GetInt("PU1") == 1)
        {
            RCP1.enabled = true;
        } else
        {
            RCP1.enabled = false;
        }
        if (PlayerPrefs.GetInt("PU2") == 1)
        {
            RCP2.enabled = true;
        } else
        {
            RCP2.enabled = false;
        }
        if (PlayerPrefs.GetInt("PU3") == 1)
        {
            RCP3.enabled = true;
        } else
        {
            RCP3.enabled = false;
        }
        //Overall
        if (PlayerPrefs.GetInt("OVU") == 1)
        {
            RCOV.enabled = true;
        } else
        {
            RCOV.enabled = false;
        }
        
    }

    public void RedUpgrade1()
    {
        if (Coins >= 200 && PlayerPrefs.GetInt("RU1") != 1)
        {
            Coins -= 200;
            PlayerPrefs.SetInt("RU1", 1);
        }
        else
        {

            CantBuy.enabled = true;
          
            CantBuy.enabled = false;
        }

    }
    public void RedUpgrade2()
    {
        if (Coins >= 300 && PlayerPrefs.GetInt("RU2") != 1)
        {
            Coins -= 300;
            PlayerPrefs.SetInt("RU2", 1);
        }
        else
        {
            CantBuy.enabled = true;
            
            CantBuy.enabled = false;
        }
    }
    public void RedUpgrade3()
    {
        if (Coins >= 400 && PlayerPrefs.GetInt("RU3") != 1)
        {
            Coins -= 400;
            PlayerPrefs.SetInt("RU3", 1);
        }
        else
        {
            CantBuy.enabled = true;
          
            CantBuy.enabled = false;

        }
    }
    public void GreenUpgrade1()
    {
        if (Coins >= 200 && PlayerPrefs.GetInt("GU1") != 1)
        {
            Coins -= 200;
            PlayerPrefs.SetInt("GU1", 1);
        }
        else
        {
            CantBuy.enabled = true;
           
            CantBuy.enabled = false;
        }
    }
    public void GreenUpgrade2()
    {
        if (Coins >= 300 && PlayerPrefs.GetInt("GU2") != 1)
        {
            Coins -= 300;
            PlayerPrefs.SetInt("GU2", 1);
        }
        else
        {
            CantBuy.enabled = true;
         
            CantBuy.enabled = false;
        }
    }
    public void GreenUpgrade3()
    {
        if (Coins >= 400 && PlayerPrefs.GetInt("GU3") != 1)
        {
            Coins -= 400;
            PlayerPrefs.SetInt("GU3", 1);
        }
        else
        {
            CantBuy.enabled = true;
          
            CantBuy.enabled = false;
        }

    }
    public void PurpleUpgrade1()
    {
        if (Coins >= 200 && PlayerPrefs.GetInt("PU1") != 1)
        {
            Coins -= 200;
            PlayerPrefs.SetInt("PU1", 1);
        }
        else
        {
            CantBuy.enabled = true;
           
            CantBuy.enabled = false;
        }
    }
    public void PurpleUpgrade2()
    {
        if (Coins >= 300 && PlayerPrefs.GetInt("PU2") != 1)
        {
            Coins -= 300;
            PlayerPrefs.SetInt("PU2", 1);
        }
        else
        {
            CantBuy.enabled = true;
            
            CantBuy.enabled = false;
        }
    }
    public void PurpleUpgrade3()
    {
        if (Coins >= 400 && PlayerPrefs.GetInt("PU3") != 1)
        {
            Coins -= 400;
            PlayerPrefs.SetInt("PU3", 1);
        }
        else
        {
            CantBuy.enabled = true;
            
            CantBuy.enabled = false;
        }
    }
    public void OverallUpgrade()
    {
        if (Coins >= 500 && PlayerPrefs.GetInt("OVU") != 1)
        {
            Coins -= 500;
            PlayerPrefs.SetInt("OVU", 1);
        }
        else
        {
            CantBuy.enabled = true;
         
            CantBuy.enabled = false;

        }
    }
    public void ResetUpgrades()
    {
        PlayerPrefs.SetInt("OVU", 0);
        PlayerPrefs.SetInt("RU1", 0);
        PlayerPrefs.SetInt("RU2", 0);
        PlayerPrefs.SetInt("RU3", 0);

        PlayerPrefs.SetInt("GU1", 0);
        PlayerPrefs.SetInt("GU2", 0);
        PlayerPrefs.SetInt("GU3", 0);

        PlayerPrefs.SetInt("PU1", 0);
        PlayerPrefs.SetInt("PU2", 0);
        PlayerPrefs.SetInt("PU3", 0);

    }
 
}
