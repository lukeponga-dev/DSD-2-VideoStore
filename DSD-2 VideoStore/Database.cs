using System;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    public class Database
    {
        //Data Source=DESKTOP-BOJJVGV\\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;
        private string strConString = @"Data Source=DESKTOP-BOJJVGV\\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;";
        private string sql = string.Empty;
        private string id = string.Empty;
        private int intRow = 0;

        private MessageBoxButtons okButton = MessageBoxButtons.OK;
        private MessageBoxIcon infoIcon = MessageBoxIcon.Information;

        private void ResetMe()
        {
            this.id = String.Empty;


        }
    }
}