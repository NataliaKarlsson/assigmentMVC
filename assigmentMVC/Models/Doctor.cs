﻿namespace assigmentMVC.Models
{
    public class Doctor
    {
        public static string Diagnose(double temp)
        {
            bool temperature = false;
            while (!temperature)
            {
                if(temp == 37)
                {
                    return "you do not have tamp";
                    temperature = true;
                }
                else if (temp >36 && temp < 38)
                {
                    return "You have temp";
                }
                else if(temp < 36)
                {
                    return "You have hypothermia";
                }
                else if(temp > 38 && temp < 40)
                {
                    return "You are sick";
                }
                else if (temp > 40)
                {
                    return "You should call to the Ambulance";
                }
            }
            return "Temp";
            //return (temp > 37) ? "Doctor says you have a fever..have cookie" : "Doc ";
        }
    }
}