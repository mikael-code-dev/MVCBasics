namespace MVCBasics.Models
{
    public class DoctorModel
    {
        public static string CheckTemp(double temp, string selectScale)
        {
            string msg = "";

            if (selectScale == "celsius")
            {
                if (temp >= 38)
                {
                    msg = "You have a fever";
                }
                else if (temp <= 36)
                {
                    msg = "You have hypothermia";
                }
                else
                {
                    msg = "You don't have a fever. Helathy as a nut!";
                }
            }
            else
            {
                if (temp >= 100.4)
                {
                    msg = "You have a fever";
                }
                else if (temp <= 96.8)
                {
                    msg = "You have hypothermia";
                }
                else
                {
                    msg = "You don't have a fever. Helathy as a nut!";
                }
            }

            return msg;
        }
    }
}
