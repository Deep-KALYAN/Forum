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
using System.Threading;
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
        List<BOTopic> _lstBOTopics;
        List<BOReply> _lstBOReplies;
        ///GetToicdetails
        CancellationTokenSource GetToicdetailsCancelationToken = null;
        public Form1()
        {
            InitializeComponent();
        }

        #region Form1_Load

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fbuttonLogout.Visible = false;

                await RefreshAsync();
                InitializeBinding();

                ftableLayoutPanel3ForumTopic.ColumnStyles[1].Width = 1;
                ftableLayoutPanel4ForumReply.ColumnStyles[1].Width = 1;


                rbutton1Dev.PerformClick();
                // await RefreshTopicsAsync(1, 0);
                // InitializeTopicBinding();
                //utabPageUser.SuspendLayout();
                // utabPageUser.Enabled = false;
                //await RefreshRepliesAsync(1, 0);
                //InitializeReplyBinding();
                // ftabPageForum  // utabPageUser
                // tabControlForumUsers.Enabled = false;
                //((Control)this.utabPageUser).Enabled = false;


                tabControlForumUsers.Controls.Remove(utabPageUser);
                tabControlForumUsers.Controls.Remove(tabPageAccount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
            }


        }
        #endregion

        #region InitializeBinding() user 

        public void InitializeBinding()
        {
            if (_lstBOUsers != null && _lstBOUsers.Count > 0)
            {
                utextBox7updateId.DataBindings.Add("Text", bindingSourceUsers, "Id", false, DataSourceUpdateMode.Never);
                utextBox6updateName.DataBindings.Add("Text", bindingSourceUsers, "Name", false, DataSourceUpdateMode.Never);
                utextBox5updateFirstName.DataBindings.Add("Text", bindingSourceUsers, "First_Name", false, DataSourceUpdateMode.Never);
                utextBox4updateLoginName.DataBindings.Add("Text", bindingSourceUsers, "Login_Name", false, DataSourceUpdateMode.Never);
                utextBox3updatePhoneNo.DataBindings.Add("Text", bindingSourceUsers, "Ph_No", false, DataSourceUpdateMode.Never);
                utextBox2updateEmail.DataBindings.Add("Text", bindingSourceUsers, "E_Mail", false, DataSourceUpdateMode.Never);
                //  utextBox1updatePassword.DataBindings.Add("Text", bindingSourceUsers, "Password", false, DataSourceUpdateMode.Never);
            }


        }

        public void InitializeTopicBinding()
        {
            if (_lstBOTopics != null && _lstBOTopics.Count > 0)
            {
                ////Add
                //ftextBox2RubricId.DataBindings.Add("Text", bindingSourceTopics, "RubricId", false, DataSourceUpdateMode.Never);
                ////Update
                //ftextBox4TopicUpdateTitle.DataBindings.Add("Text", bindingSourceTopics, "TopicTitle", false, DataSourceUpdateMode.Never);
                //frichTextBox2UpdateTopicText.DataBindings.Add("Text", bindingSourceTopics, "TopicText", false, DataSourceUpdateMode.Never);
                //ftextBox3UpdateTopicId.DataBindings.Add("Text", bindingSourceTopics, "TopicId", false, DataSourceUpdateMode.Never);
            }

        }

        public void InitializeReplyBinding()
        {

        }
        #endregion

        #region User Buttons cru


        private async void ubuttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Delete?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
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
            DialogResult dialogResult = MessageBox.Show("Do you really want to Update?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
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
        }

        private async void ubuttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshAsync();
            //InitializeBinding();
        }


        #endregion

        #region Login_Click Button

        private async void fbuttonLogin_Click(object sender, EventArgs e)
        {
           // textBox2.Text = "";
            label1ForumRoles.Text = "";
            bool rollAdmin = false;
            var jwt = await _dalWF.Login(ftextBoxLoginName.Text, ftextBoxPassword.Text);
            if (jwt == null)
            {
                MessageBox.Show("Error login");
            }
            else
            {
               // textBox1.Text = jwt;
                var roles = _dalWF.GetRoles();
                bool userRole = false;

                //Topic buttons tab
                ftabControl1TopicCRUD.Controls.Remove(ftabPage2UpdateTopic);
                ftabControl1TopicCRUD.Controls.Remove(ftabPage3DeleteTopic);

                //Reply button tab
                ftabControl2ReplyCRUD.Controls.Remove(ftabPage5UpdateTopic);
                ftabControl2ReplyCRUD.Controls.Remove(ftabPage6DeleteReply);

                foreach (var role in roles)
                {
                    ftableLayoutPanel3ForumTopic.ColumnStyles[1].Width = 420;
                    ftableLayoutPanel4ForumReply.ColumnStyles[1].Width = 420;
                    //user tab only Admin have right to enter
                    if (role == "ADMIN")
                    {
                        //by clicking again and again it'll not open the Users tab multiple times
                        if (!tabControlForumUsers.TabPages.Contains(utabPageUser))
                        {
                        tabControlForumUsers.Controls.Add(utabPageUser);//tabControlForumUsers.Enabled = true;
                        }


                        if (tabControlForumUsers.TabPages.Contains(tabPageAccount))
                        {
                            tabControlForumUsers.Controls.Remove(tabPageAccount);//tabControlForumUsers.Enabled = true;
                        }


                        //Topic buttons tab
                        ftabControl1TopicCRUD.Controls.Add(ftabPage2UpdateTopic);
                        ftabControl1TopicCRUD.Controls.Add(ftabPage3DeleteTopic);

                        //Reply button tab
                        ftabControl2ReplyCRUD.Controls.Add(ftabPage6DeleteReply);

                        rbutton1Dev.PerformClick();
                        // await RefreshAsync();

                        //Use as Flag
                        rollAdmin = true;
                    }

                    if (rollAdmin == false)
                    {
                        if (!tabControlForumUsers.TabPages.Contains(tabPageAccount))
                        {
                            tabControlForumUsers.Controls.Add(tabPageAccount);
                            //To fill the Account text boxes 
                            
                            await RefreshAccountAsync();

                        }
                    }

                    // To display in French
                    if (role == "USER")
                    {
                        userRole = true;
                        label1ForumRoles.Text += "Utilisateur" + "  ";
                    }

                    if (role == "ADMIN")
                    {
                        label1ForumRoles.Text += "Modérateur" + "  ";
                    }

                    //if (role == "USER")
                    //{
                    //    userRole = true;         
                    //}

                    //label1ForumRoles.Text += role + "  ";
                  
                }
                if (userRole == true)
                {
                    panelLogin.Visible = false;
                    fbuttonLogout.Visible = true;

                }


            }
        }

        #endregion

        #region Rubric Buttons


        private async void rbutton1Dev_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Développement  Sujets";
            int id = 1;
            // fdataGridView1Topics.DataSource = bindingSourceTopics;
            await RefreshTopicsAsync(id);
        }
        private async void rbutton2Adre_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Adresses utiles Sujets";
            int id = 2;

            await RefreshTopicsAsync(id);
        }

        private async void rbutton3Ques_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Questions diverses Sujets";
            int id = 3;

            await RefreshTopicsAsync(id);
        }

        private async void rbutton4EspaceD_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Espace Détente Sujets";
            int id = 4;
            await RefreshTopicsAsync(id);
        }

        private async void rbutton5Galerie_Click(object sender, EventArgs e)
        {
            ftextBox1RubNameTopics.Text = "Galerie Sujets";
            int id = 5;
            await RefreshTopicsAsync(id);
        }
        #endregion

        #region Refresh ResetBindings User, Topic, Reply, Account

        //user
        private async Task RefreshAsync(int position = 0)
        {
            _lstBOUsers = await _dalWF.GetAllUsersAsync();
            if (_lstBOUsers != null && _lstBOUsers.Count > 0)
            {
                udataGridViewUsers.DataSource = bindingSourceUsers;
                bindingSourceUsers.DataSource = _lstBOUsers;
                bindingSourceUsers.ResetBindings(false);
                bindingSourceUsers.Position = _lstBOUsers.FindIndex(u => u.Id == position);
            }
            else
            {
                udataGridViewUsers.DataSource = null;
            }
        }


        //topic
        private async Task RefreshTopicsAsync(int id, int? position = 0)
        {
            EmptyForum();

            ftextBox2RubricId.Text = id.ToString();

            _lstBOTopics = await _dalWF.GetTopicsByRubricIdAsync(id);
            // _lstBOReplies = null;

            if (_lstBOTopics != null && _lstBOTopics.Count > 0)
            {

                fdataGridView1Topics.DataSource = bindingSourceTopics;
                bindingSourceTopics.DataSource = _lstBOTopics;
                bindingSourceTopics.ResetBindings(false);
                bindingSourceTopics.Position = _lstBOTopics.FindIndex(u => u.TopicId == position);
            }
            else
            {
                //_lstBOTopics.Clear();

                if (_lstBOReplies != null && _lstBOReplies.Count > 0)
                {
                    _lstBOReplies.Clear();
                }
            }
        }

        //reply
        private async Task RefreshRepliesAsync(int id, int position = 0, CancellationToken cancellationToken = default)
        {
                        
            //ftextBoxPassword.Text += "a"; //************************************
          
            _lstBOReplies = await _dalWF.GetRepliesDetailByTopicIdAsync(id, cancellationToken);

            //ftextBoxPassword.Text += "b"; //*************************************


            if (_lstBOReplies != null && _lstBOReplies.Count > 0)
            {
                if (fdataGridView2Replies.DataSource == null)
                    fdataGridView2Replies.DataSource = bindingSourceReplies;

                bindingSourceReplies.DataSource = _lstBOReplies;
                bindingSourceReplies.ResetBindings(false);
                bindingSourceReplies.Position = _lstBOReplies.FindIndex(r => r.ChildReplyId == position);
            }
            //else 
            //{
            //    ; 
            //}
            else
            {
                fdataGridView2Replies.DataSource = null;

                //add
                ftextBox4ReplyTopicId.Text = "";
                ftextBox3ReplyParentId.Text = "NULL";
                frichTextBox1ReplyAddText.Text = "";

                //update
                frichTextBox2ReplyUpdateText.Text = "";
                ftextBox5ReplyId.Text = "";
            }

            //else
            //{
            //    //bindingSourceReplies.DataSource = null;  //to clear the binding list
            //}
        }

        //Account
        private async Task RefreshAccountAsync()
        {
            int userId = Int32.Parse(_dalWF.GetUserId());
            var account = await _dalWF.GetUsersByIdAsync(userId);
            if (account != null)
            {

            AccountTextBoxId.Text = _dalWF.GetUserId();//account.Id.ToString();
            AccountTextBoxFirstName.Text = account.First_Name;
            AccountTextBoxName.Text = account.Name;
            AccountTextBoxLoginName.Text = account.Login_Name;
            AccountTextBoxPhoneNo.Text = account.Ph_No;
            AccountTextBoxEmail.Text = account.E_Mail;
            AccountTextBoxPassword.Text = "password";
            }

        }

            #endregion

        #region EmptyForum

            private void EmptyForum()
        {
            fdataGridView1Topics.DataSource = null;
            fdataGridView2Replies.DataSource = null;



            /// Topic
            //add
            ftextBox2RubricId.Text = "";
            ftextBox1TopicTitle.Text = "";
            frichTextBox1TopicText.Text = "";

            ////Update
            ftextBox4TopicUpdateTitle.Text = "";
            frichTextBox2UpdateTopicText.Text = "";
            ftextBox3UpdateTopicId.Text = "";

            //heading of replies
            ftextBoxTopicNameReplies.Text = "";

            ///Reply
            //add
            ftextBox4ReplyTopicId.Text = "";
            ftextBox3ReplyParentId.Text = "NULL";
            frichTextBox1ReplyAddText.Text = "";

            //update
            frichTextBox2ReplyUpdateText.Text = "";
            ftextBox5ReplyId.Text = "";

        }

        #endregion

        #region ToolTip

        //tool tip event for User tab

        private void tabControlForumUsers_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Only for Admin", tabControlForumUsers);
        }






        #endregion

        #region BindingSource CurrentChange  User, Topic, Reply

        //  int[] array = new int[] { };
        private void bindingSourceUsers_CurrentChanged(object sender, EventArgs e)
        {
            var currentUser = (BOUser)bindingSourceUsers.Current;
            //   MessageBox.Show(currentUser.First_Name);
            if (currentUser != null)// (currentReply.ChildReplyId != 0 )
            {
                utextBox7updateId.Text = currentUser.Id.ToString();
                utextBox6updateName.Text = currentUser.Name;
                utextBox5updateFirstName.Text = currentUser.First_Name;
                utextBox4updateLoginName.Text = currentUser.Login_Name;
                utextBox3updatePhoneNo.Text = currentUser.Ph_No;
                utextBox2updateEmail.Text = currentUser.E_Mail;
            }
            else
            {
                utextBox7updateId.Text = "";
                utextBox6updateName.Text = "";
                utextBox5updateFirstName.Text = "";
                utextBox4updateLoginName.Text = "";
                utextBox3updatePhoneNo.Text = "";
                utextBox2updateEmail.Text = "";
            }

        }

        private async void bindingSourceTopics_CurrentChanged(object sender, EventArgs e)
        {
            var currentTopic = (BOTopic)bindingSourceTopics.Current;
            //ftextBox2RubricId.DataBindings.Add("Text", bindingSourceTopics, "RubricId", false);

            int id = 0;

            //  MessageBox.Show("heeee"); //(currentUser.TopicId.ToString());
            if (currentTopic != null)
            {
                if (currentTopic.TopicId == null || currentTopic.TopicId == 0)
                {
                    id = 0;
                }
                else
                {
                    id = (int)currentTopic.TopicId;
                }
               // ftextBoxPassword.Text += "°"; //*****************************************

                if(GetToicdetailsCancelationToken is not null)
                {
                    GetToicdetailsCancelationToken.Cancel();
                }
                GetToicdetailsCancelationToken = new CancellationTokenSource();
                Task refreshTask = RefreshRepliesAsync(id, 0, GetToicdetailsCancelationToken.Token);

                try
                {
                    await refreshTask;
                }catch { return; }
                

                //  ftextBoxPassword.Text += id.ToString(); //********************************

                ftextBoxTopicNameReplies.Text = currentTopic.TopicTitle + "  Réponses";

                ////Add
                ftextBox2RubricId.Text = currentTopic.RubricId.ToString();

                ////Update
                ftextBox4TopicUpdateTitle.Text = currentTopic.TopicTitle;
                frichTextBox2UpdateTopicText.Text = currentTopic.TopicText;
                ftextBox3UpdateTopicId.Text = currentTopic.TopicId.ToString();
            }
            else
            {
                ftextBoxTopicNameReplies.Text = "";

                //add
                ftextBox2RubricId.Text = "";

                ////Update
                ftextBox4TopicUpdateTitle.Text = "";
                frichTextBox2UpdateTopicText.Text = "";
                ftextBox3UpdateTopicId.Text = "";

                if (_lstBOReplies != null) // || (!_lstBOReplies.Any())
                {
                    _lstBOReplies.Clear();
                }
                bindingSourceReplies.ResetBindings(false);
            }
        }

        private void bindingSourceReplies_CurrentChanged(object sender, EventArgs e)
        {
            var currentReply = (BOReply)bindingSourceReplies.Current;
            if (currentReply != null)// (currentReply.ChildReplyId != 0 )
            {
                ftextBox4ReplyTopicId.Text = currentReply.TopicId.ToString();   //Topic.TopicId.ToString();   
                frichTextBox2ReplyUpdateText.Text = currentReply.ChildReplyText;
                ftextBox5ReplyId.Text = currentReply.ChildReplyId.ToString();
            }
            else
            {
                ftextBox4ReplyTopicId.Text = "";
                frichTextBox2ReplyUpdateText.Text = "";
                ftextBox5ReplyId.Text = "";
            }
            //InitializeReplyBinding();            
        }






        #endregion

        #region Topic Buttons


        private async void fbutton1TopicAdd_Click(object sender, EventArgs e)
        {



            //var currentTopic = (BOTopic)bindingSourceUsers.Current;
            //if (currentTopic != null)
            //{
            int rubricId = 0;
            if (ftextBox2RubricId.Text != null) rubricId = Convert.ToInt32(ftextBox2RubricId.Text);

            var newTopic = await _dalWF.AddTopicAsync(rubricId, ftextBox1TopicTitle.Text, frichTextBox1TopicText.Text, GetCreatorId());
            if (newTopic == null)
            {
                MessageBox.Show("Error Add");
            }
            else
            {
               // MessageBox.Show("Successfully Added");
                await RefreshTopicsAsync(rubricId, (int)newTopic.TopicId);
            }
            // }
        }

        private async void fbutton2TopicUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                //(int)currentTopic.TopicId,
                var currentTopic = (BOTopic)bindingSourceTopics.Current;
                if (currentTopic != null)
                {
                    var res = await _dalWF.UpdateTopicAsync(
                        ftextBox4TopicUpdateTitle.Text,
                        frichTextBox2UpdateTopicText.Text,
                        (int)currentTopic.TopicId,
                        currentTopic.RubricId,
                        GetCreatorId());
                    if (res == null)
                    {
                        MessageBox.Show("Error Update");
                    }
                    else
                    {

                        await RefreshTopicsAsync(currentTopic.RubricId, (int)currentTopic.TopicId);
                    }
                }
            }
        }

        private async void fbutton3TopicDelete_Click(object sender, EventArgs e)
        {
            //var currentReply = (BOReply)bindingSourceReplies.Current;
            //int Idreply = 0;
            //if (currentReply != null)
            //{
            //    Idreply = currentReply
            //}

            DialogResult dialogResult = MessageBox.Show("Do you really want to Delete?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var currentTopic = (BOTopic)bindingSourceTopics.Current;
                if (currentTopic != null)
                {
                    bool res = await _dalWF.DeleteTopicAsync((int)currentTopic.TopicId);
                    if (!res)
                    {
                        MessageBox.Show("Error Delete");
                    }
                    else
                    {

                        await RefreshTopicsAsync(currentTopic.RubricId);
                    }
                }
            }
        }



        #endregion

        #region Reply Buttons


        private async void fbutton1ReplyAdd_Click(object sender, EventArgs e)
        {
            int? parentId = null;
            int n;
            bool isNumeric = int.TryParse(ftextBox3ReplyParentId.Text, out n);
            if (isNumeric)
            {
                if (n > 0)
                {
                    parentId = n;
                }
                else
                {
                    MessageBox.Show("Error Add Reply, number should be positive");
                }
            }


            //int topicId = 0;
            //if (ftextBox4ReplyTopicId.Text != null) 
            int topicId = Convert.ToInt32(ftextBox4ReplyTopicId.Text);
            var newReply = await _dalWF.AddReplyAsync(frichTextBox1ReplyAddText.Text, parentId, topicId, GetCreatorId());
            if (newReply == null)
            {
                MessageBox.Show("Error Add Reply");
            }
            else
            {

                await RefreshRepliesAsync(topicId, (int)newReply.ChildReplyId);
            }
        }

        private async void fbutton2ReplyUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Update?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var currentReply = (BOReply)bindingSourceReplies.Current;
                if (currentReply != null)
                {
                    var res = await _dalWF.UpdateReplyAsync(
                        frichTextBox2ReplyUpdateText.Text,
                        currentReply.ChildReplyId,
                        GetCreatorId());
                    if (res == null)
                    {
                        MessageBox.Show("Error Update");
                    }
                    else
                    {
                        await RefreshRepliesAsync(currentReply.TopicId, (int)res.ChildReplyId);
                    }
                }
                else
                {
                    MessageBox.Show("Error Update");
                }
            }
        }

        private async void fbutton3ReplyDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Delete?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var currentReply = (BOReply)bindingSourceReplies.Current;
                if (currentReply != null)
                {
                    bool res = await _dalWF.DeleteReplyAsync(currentReply.ChildReplyId);
                    if (!res)
                    {
                        MessageBox.Show("Error Delete");
                    }
                    else
                    {

                        await RefreshRepliesAsync(currentReply.TopicId);
                    }
                }
            }
        }


        #endregion

        #region LogOut Button
        private async void fbuttonLogout_Click(object sender, EventArgs e)
        {
            var roles = _dalWF.GetRoles();
            if (roles.Contains("ADMIN"))
            {
                tabControlForumUsers.Controls.Remove(utabPageUser);//tabControlForumUsers.Enabled = true;
                await RefreshAsync();
               
            }

            if (roles.Contains("USER"))
            {               
                tabControlForumUsers.Controls.Remove(tabPageAccount);
                await RefreshAsync();
            }


            _dalWF.SetRoles();
            _dalWF.SetUserId();
         //   textBox2.Text = "Public";
            label1ForumRoles.Text = "Public";
            panelLogin.Visible = true;
            fbuttonLogout.Visible = false;

            //Form1 form1 = new Form1();
            //form1.ActiveControl.Refresh();
            //Form1.ActiveForm.Refresh();

            //this.Controls.Clear();
            //this.InitializeComponent();

            //Form1 form = new Form1();
            //form.WindowState = FormWindowState.Maximized;

            ftableLayoutPanel3ForumTopic.ColumnStyles[1].Width = 1;
            ftableLayoutPanel4ForumReply.ColumnStyles[1].Width = 1;

            //tabControlForumUsers.Controls.Remove(utabPageUser);

            rbutton1Dev.PerformClick();

            //tabControlForumUsers.Enabled = false;
            //await RefreshAsync();
            //InitializeBinding();
            //rbutton1Dev.PerformClick();
            //tabControlForumUsers


        }

        #endregion

        #region get login user id

        private int GetCreatorId()
        {
            int creatorId;
            string userId = _dalWF.GetUserId();
            if (userId != null)
            {

                return creatorId = Convert.ToInt32(userId);
            }
            else
            {
                MessageBox.Show("Error, you must login before");
                return creatorId = 0;
            }
        }




        #endregion

        #region dataGridViews TOPIC & REPLY, hide column and change the color(on Deleted reply) CellFormatting

        private void fdataGridView2Replies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //fdataGridView2Replies.Columns[0].Width = 450;
            fdataGridView2Replies.Columns[0].HeaderText = "Réponse"; // "Reply";
            fdataGridView2Replies.Columns[1].HeaderText = "Créateur"; // "Reply Creator";
            fdataGridView2Replies.Columns[2].HeaderText = "Publié"; // "Date de réponse"; // "Reply Date";
            //fdataGridView2Replies.Columns[3].Width = 400;
            fdataGridView2Replies.Columns[3].HeaderText = "Réponse Parent"; // "Parent Reply";
            fdataGridView2Replies.Columns[4].HeaderText = "Créateur Parent"; //"Parent Reply Creator";
            fdataGridView2Replies.Columns[5].HeaderText = "Publié Parent"; //"Parent Reply Date";




            fdataGridView2Replies.Columns[6].Visible = true;
            fdataGridView2Replies.Columns[6].HeaderText = "Réponse Id"; // "Reply Id";
            fdataGridView2Replies.Columns[6].Width = 40;

            fdataGridView2Replies.Columns[7].Visible = false;
            fdataGridView2Replies.Columns[8].Visible = false;
            fdataGridView2Replies.Columns[9].Visible = false;
            fdataGridView2Replies.Columns[10].Visible = false;
            fdataGridView2Replies.Columns[11].Visible = false;
            fdataGridView2Replies.Columns[12].Visible = false;


            foreach (DataGridViewRow row in fdataGridView2Replies.Rows)
            {
                var cellValue = row.Cells[11].Value;
                // if(rowCell != null) Boolean cellValue = (Boolean)rowCell);
                if (cellValue != null && cellValue is bool) // DateTime.TryParse(cellText, out compareDate))
                {
                    if ((Boolean)cellValue == true)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Honeydew;
                    }
                }

            }
        }
        private void fdataGridView1Topics_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           // fdataGridView1Topics.Columns[0].Width = 430;
            fdataGridView1Topics.Columns[0].HeaderText = "Titre du sujet";  //"Topic Title";

           // fdataGridView1Topics.Columns[1].Width = 430;
            fdataGridView1Topics.Columns[1].HeaderText = "Texte";  //"Topic Text";

            fdataGridView1Topics.Columns[2].HeaderText = "Créateur";  //"Topic Creator";
            fdataGridView1Topics.Columns[3].HeaderText = "Publié";  //"Published Date";

            fdataGridView1Topics.Columns[4].Visible = false;
            fdataGridView1Topics.Columns[5].Visible = false;
            fdataGridView1Topics.Columns[6].Visible = false;




        }
        private void udataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            udataGridViewUsers.Columns[0].HeaderText = "Id";//"Id";
            udataGridViewUsers.Columns[1].HeaderText = "Nom";//"Name";
            udataGridViewUsers.Columns[2].HeaderText = "Prénom";//"First_Name";
            udataGridViewUsers.Columns[3].HeaderText = "Nom de connection";//"Login_Name";
            udataGridViewUsers.Columns[4].HeaderText = "Télephone";//"Ph_No";
            udataGridViewUsers.Columns[5].HeaderText = "EMail";//"E_Mail";
            udataGridViewUsers.Columns[6].HeaderText = "Moderator_Y_N";//"Moderator_Y_N";
            udataGridViewUsers.Columns[7].HeaderText = "Password";//"Password";
        }

        #endregion

        #region Account Buttons
        private async void AccountButtonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update?", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var updateUser = await _dalWF.UpdateUserAsync(
                     Int32.Parse(AccountTextBoxId.Text),
            AccountTextBoxName.Text,
            AccountTextBoxFirstName.Text,
            AccountTextBoxLoginName.Text,
            AccountTextBoxPhoneNo.Text,
            AccountTextBoxEmail.Text,
            AccountTextBoxPassword.Text
                    );
                if (updateUser != null)
                {
                    MessageBox.Show("Successfully Updated");
                    await RefreshAccountAsync();
                }
                else
                {
                    MessageBox.Show("Erreur");

                }
            }
        }

        private async void AccountButtonRefresh_Click(object sender, EventArgs e)
        {
           await RefreshAccountAsync();
        }


        #endregion

    }
}
