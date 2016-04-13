using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI.LoginScreen
{
    public delegate void login_method(String userName, String IP, Boolean isGM, String gameMode, takes_string error_reporting);
    public partial class LoginScreen_GUI : Form
    {
        login_method login;
        public String[] selections
        {
            set
            {
                ModeSelection.DataSource = value;
            }
                
        }

        public LoginScreen_GUI(login_method method)
        {
            InitializeComponent();

            String[] selections = { "Mistborn" };
            this.selections = selections;

            TopLevel = false;
            Dock = DockStyle.Fill;

            ModeSelection.Visible = false;
            modeLbl.Visible = false; 
            
            isGM.CheckedChanged += isGM_selected;
            ConnectButton.Click += ConnectionButton_Click;

            login = method;

            ServerIP.Text = "127.0.0.1:8733";
        }

        public void ConnectionButton_Click(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            String reg = "([1]{0,1}[0-9]{0,1}[0-9]|[2][0-4][0-9]|[2][5][0-5])";
            reg = "^" + reg + "[.]" + reg + "[.]" + reg + "[.]" + reg + "[:][0-9]{1,5}$";

            if (String.IsNullOrEmpty(UserName.Text))
            {
                UserName.BackColor = Color.Orange;
                tip.SetToolTip(UserName, "Must enter a username");
            }
            else if (!Regex.IsMatch(ServerIP.Text.Trim(), reg))
            {
                ServerIP.BackColor = Color.Red;
                tip.SetToolTip(ServerIP, "Invalid IP, must be in the form of: XXX.XXX.XXX.XXX:XXXX");
            }
            else
            {
                String gamemode;
                if(isGM.Checked){
                    gamemode = ModeSelection.SelectedValue.ToString();
                }
                else{
                    gamemode = null;
                }

                login(UserName.Text, ServerIP.Text, isGM.Checked, gamemode, error_reporting);
            }
        } // End ConnectionButton_Click

        public void error_reporting(String message)
        {
            errorLbl.Text = message;
        }
        
        public void isGM_selected(object sender, EventArgs e)
        {
            if (isGM.Checked)
            {
                ModeSelection.Visible = true;
                modeLbl.Visible = true;
            }
            else
            {
                ModeSelection.Visible = false;
                modeLbl.Visible = false;
            }
        } // End isGM_selected
    
    }
}
