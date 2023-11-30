using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrealSharpMemory.Memory;

namespace UnrealSharpInspector
{
    public partial class Form_Inspector : Form
    {
        bool game_open = false;

        public Form_Inspector()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            if (CustomMem._0m.OpenProcess("your game.exe"))  { 
                game_open = true;
            }
            else { 
                game_open = false; 
            }
        }

        private void Form_Inspector_Load(object sender, EventArgs e)
        {

        }

        private void ActorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (game_open == false) return;
                var actorAddr = nint.Parse(ActorList.SelectedItem.ToString().Split(':')[0].Replace(" ", ""));
            }
            catch (Exception m) { MessageBox.Show(m.Message); }
        }

        private void ActorInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (game_open == false) return;
                var actorAddr = nint.Parse(ActorInfo.Items[0].ToString().Split(':')[0].Replace(" ", ""));
                var fName = ActorInfo.SelectedItem.ToString().Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
            }
            catch (Exception m) { MessageBox.Show(m.Message); }
        }

        private void DumpSDK_Click(object sender, EventArgs e)
        {
            try
            {
                if (game_open == false) return;
            }
            catch (Exception m) { MessageBox.Show(m.Message); }
        }

        private void DumpActorList_Click(object sender, EventArgs e)
        {
            try
            {
                if (game_open == false) return;
                ActorList.Items.Clear();
            }
            catch (Exception m) { MessageBox.Show(m.Message); }
        }
    }
}
