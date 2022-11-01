using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date : MonoBehaviour
{
    public int year = 2022;
    public int i_month = 1;
    public string month
    {
        get {
            switch (i_month)
            {
                case 1:
                    return("January");
                case 2:
                    return("February");
                case 3:
                    return ("March");
                case 4:
                    return ("April");
                case 5:
                    return ("May");
                case 6:
                    return ("June");
                case 7:
                    return ("Jule");
                case 8:
                    return ("August");
                case 9:
                    return ("September");
                case 10:
                    return ("October");
                case 11:
                    return ("November");
                case 12:
                    return ("December");
            }
            return month; }
        set
        {            
        }
    }
    public int day = 1;
    public float timeset = 1;
}
