using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteORM;

namespace WMPlayer
{
    public partial class PlayListForm : Form
    {

        private SQLiteDBEngine dBEngine;

        public PlayListForm()
        {
            InitializeComponent();
        }
        private void PlayListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button_Add_Treck_Click(object sender, EventArgs e)
        {
            database();
            SQLiteTable Students = dBEngine["student"];           
            foreach (var col in Students.BodyRows)
            {              
                foreach (var item in col.Value)
                {                    
                    listBox_Playlists.Items.Add(item);
                }
            }
           
          
            
        }

        private void database()
        {
            /*string pathTofile = */
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "test.db");
            // string pathTofile = @"D:\c#\lesson11\SQLiteDatabaseBrowserPortable\PlayList1.db";
            //string pathTofile = @"D:\c#\lesson19\SQLiteORMCRUDNewMethod\SQLiteORM\SQLiteORM\bin\Debug\database\test.db";
            string pathTofile = @" D:\c#\lesson27\WMPlayer\WMPlayer\bin\Debug\test.db";
            dBEngine = new SQLiteDBEngine(pathTofile, SQLIteMode.EXISTS);


        }

     
    }
}
