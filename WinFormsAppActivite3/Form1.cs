using Domain.DTO.Requestes.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppActivite3.DomainWF.BOWF;
using WinFormsAppActivite3.DomainWF.DTOWF.ResponseWF;

namespace WinFormsAppActivite3
{
    public partial class Form1 : Form
    {
        DALWF _dalWF = new DALWF();
        List<BOUser> _lstBOUsers;
        List<BOTopics> _lstBOTopics;
        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {

            //_lstBOUsers = await _dalWF.GetAllUsersAsync();
            udataGridViewUsers.DataSource = bindingSourceUsers;
            //bindingSourceUsers.DataSource = _lstBOUsers;
            //bindingSourceUsers.ResetBindings(false);

            await RefreshAsync();

            utextBox7updateId.DataBindings.Add("Text", bindingSourceUsers, "Id", false, DataSourceUpdateMode.Never);
            utextBox6updateName.DataBindings.Add("Text", bindingSourceUsers, "Name", false, DataSourceUpdateMode.Never);
            utextBox5updateFirstName.DataBindings.Add("Text", bindingSourceUsers, "First_Name", false, DataSourceUpdateMode.Never);
            utextBox4updateLoginName.DataBindings.Add("Text", bindingSourceUsers, "Login_Name", false, DataSourceUpdateMode.Never);
            utextBox3updatePhoneNo.DataBindings.Add("Text", bindingSourceUsers, "Ph_No", false, DataSourceUpdateMode.Never);
            utextBox2updateEmail.DataBindings.Add("Text", bindingSourceUsers, "E_Mail", false, DataSourceUpdateMode.Never);
            //  utextBox1updatePassword.DataBindings.Add("Text", bindingSourceUsers, "Password", false, DataSourceUpdateMode.Never);


        }

        private void bindingSourceUsers_CurrentChanged(object sender, EventArgs e)
        {
            var currentUser = (BOUser)bindingSourceUsers.Current;
            //  MessageBox.Show(currentUser.First_Name);

        }

        private async void ubuttonDelete_Click(object sender, EventArgs e)
        {
            var currentUser = (BOUser)bindingSourceUsers.Current;
            if (currentUser != null)
            {
                bool res = await _dalWF.DeleteUserAsync(currentUser.Id);
                if (!res)
                {
                    MessageBox.Show("Error Delete");
                }
                await RefreshAsync();
            }
        }

        private async Task RefreshAsync(int position = 0)
        {
            _lstBOUsers = await _dalWF.GetAllUsersAsync();

            bindingSourceUsers.DataSource = _lstBOUsers;
            bindingSourceUsers.ResetBindings(false);
            bindingSourceUsers.Position = _lstBOUsers.FindIndex(u => u.Id == position);
        }

        private async void ubuttonAdd_Click(object sender, EventArgs e)
        {
            var newUser = await _dalWF.AddUserAsync(utextBox1Name.Text, utextBox2FirstName.Text, utextBox3LoginName.Text, utextBox4PhNo.Text, utextBox5EMail.Text, utextBox6Password.Text);
            if (newUser == null)
                MessageBox.Show("Error Add");
            else
                await RefreshAsync(newUser.Id);
        }

        private async void ubuttonUpdate_Click(object sender, EventArgs e)
        {

            var currentUser = (BOUser)bindingSourceUsers.Current;
            if (currentUser != null)
            {
                var updateUser = await _dalWF.UpdateUserAsync(
                     currentUser.Id,
                     utextBox6updateName.Text,
                     utextBox5updateFirstName.Text,
                     utextBox4updateLoginName.Text,
                     utextBox3updatePhoneNo.Text,
                     utextBox2updateEmail.Text,
                     utextBox1updatePassword.Text
                    );

                if (updateUser == null)
                    MessageBox.Show("Error Add");
            }
            else
            {
                MessageBox.Show("Current user is null");
            }

            await RefreshAsync(currentUser.Id);
        }

        private async void fbuttonLogin_Click(object sender, EventArgs e)
        {
            var jwt = await _dalWF.Login(ftextBoxLoginName.Text, ftextBoxPassword.Text);
            if (jwt == null)
            {
                MessageBox.Show("Error login");
            }
            else
            {
                textBox1.Text = jwt;
                var roles = _dalWF.getRoles();
                foreach (var role in roles)
                {
                    textBox2.Text += role + ", ";
                }
            }
        }

        

        private async void rbutton1Dev_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Développement  Sujets";
            int id = 1;
            await RefreshTopicsAsync(id, 0);
            //_lstBOTopics = await _dalWF.GetTopicsByRubricIdAsync(id);  
            //fdataGridView1Topics.DataSource = bindingSourceTopics;
            //bindingSourceTopics.DataSource = _lstBOTopics;
            //bindingSourceTopics.ResetBindings(false);
            //fd  udataGridViewUsers.DataSource = bindingSourceUsers;
            //bindingSourceUsers.DataSource = _lstBOUsers;
            //bindingSourceUsers.ResetBindings(false);
            //bindingSourceUsers.Position = _lstBOUsers.FindIndex(u => u.Id == position);


        }
        private async void rbutton2Adre_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Adresses utiles Sujets";
            int id = 2;
            await RefreshTopicsAsync(id, 0);
        }

        private async void rbutton3Ques_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Questions diverses Sujets";
            int id = 3;
            await RefreshTopicsAsync(id, 0);
        }

        private async void rbutton4EspaceD_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Espace Détente Sujets";
            int id = 4;
            await RefreshTopicsAsync(id, 0);
        }

        private async void rbutton5Galerie_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Galerie Sujets";
            int id = 5;
            await RefreshTopicsAsync(id, 0);
        }

        private async Task RefreshTopicsAsync(int id, int position = 0)
        {
            //_lstBOUsers = await _dalWF.GetAllUsersAsync();

            //bindingSourceUsers.DataSource = _lstBOUsers;
            //bindingSourceUsers.ResetBindings(false);
            _lstBOTopics = await _dalWF.GetTopicsByRubricIdAsync(id);
            fdataGridView1Topics.DataSource = bindingSourceTopics;
            bindingSourceTopics.DataSource = _lstBOTopics;
            bindingSourceTopics.ResetBindings(false);
            //bindingSourceUsers.Position = _lstBOTopics.FindIndex(u => u.Id == position);
        }

    }
}
