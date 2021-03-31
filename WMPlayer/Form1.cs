using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WMPlayer
{
    public partial class MainForm : Form
    {
        private PlayListForm _playListForm;
      

        public MainForm()
        {
            InitializeComponent();
            aboutUsToolStripMenuItem.Click += AboutUsToolStripMenuItem_Click;
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            // aboutUsForm.Show();  - немодальное окно
            aboutUsForm.ShowDialog(); // - модальное окно
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string mediaPath = Assembly.GetExecutingAssembly().Location;
            mediaPath = Path.GetDirectoryName(mediaPath) + "\\Sabaton.mp4";

            axWindowsMediaPlayer.URL = mediaPath;
            toolStripStatusLabel_Info.Text = Path.GetFileName( mediaPath);
            toolStripStatusLabel_Info.ForeColor = Color.Red;


           
        }


        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_playListForm == null)
            {
                _playListForm = new PlayListForm();
                _playListForm.Location = 
                        new Point(this.Location.X + this.Size.Width - 14, this.Location.Y);
                _playListForm.Size = new Size(_playListForm.Width, this.Height);
            }
            _playListForm.Show();
        }

       

        private void toolStripStatusLabel_Info_Click(object sender, EventArgs e)
        {
          
        }
    }
}






// case SQLIteMode.NEW:
//                    {
//    SQLiteConnector.CreateDatabaseSource(dbPath);
//    //развернуть дб по заранее заложенному алгоритму
//    string query = "CREATE TABLE PlayLists5 (" +
//        "Id INTEGER NOT NULL, Title NUMERIC," +
//        "FilePath  NUMERIC NOT NULL," +
//        "Artist  TEXT, " +
//        "Album TEXT, " +
//        "TrackNumber INTEGER, " +
//        "Date TEXT," +
//        "Duration  NUMERIC," +
//        "Codec TEXT," +
//        "Playing   INTEGER," +
//        "FileName  TEXT," +
//        "FileExtension TEXT," +
//        "FileSize  NUMERIC," +
//        "Bitrate   INTEGER," +
//        "PRIMARY KEY(Id AUTOINCREMENT) ) ";
//    Console.WriteLine(query);
//    SQLiteConnector.Connection.Open();
//    SQLiteCommand sQLiteCommand = new SQLiteCommand(query, SQLiteConnector.Connection);
//    sQLiteCommand.ExecuteNonQuery();

//    break;
//}