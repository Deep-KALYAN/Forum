
namespace WinFormsAppActivite3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlForumUsers = new System.Windows.Forms.TabControl();
            this.ftabPageForum = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelForum = new System.Windows.Forms.TableLayoutPanel();
            this.flabelRubriques = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbutton1Dev = new System.Windows.Forms.Button();
            this.rbutton2Adre = new System.Windows.Forms.Button();
            this.rbutton3Ques = new System.Windows.Forms.Button();
            this.rbutton5Galerie = new System.Windows.Forms.Button();
            this.rbutton4EspaceD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ftextBox1RubNameTopics = new System.Windows.Forms.TextBox();
            this.fdataGridView1Topics = new System.Windows.Forms.DataGridView();
            this.ftextBoxTopicNameReplies = new System.Windows.Forms.TextBox();
            this.fdataGridView2Replies = new System.Windows.Forms.DataGridView();
            this.utabPageUser = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelUser = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlUserAddDelUpdate = new System.Windows.Forms.TabControl();
            this.utabPageUserAdd = new System.Windows.Forms.TabPage();
            this.utextBox6Password = new System.Windows.Forms.TextBox();
            this.utextBox5EMail = new System.Windows.Forms.TextBox();
            this.utextBox4PhNo = new System.Windows.Forms.TextBox();
            this.utextBox3LoginName = new System.Windows.Forms.TextBox();
            this.utextBox2FirstName = new System.Windows.Forms.TextBox();
            this.utextBox1Name = new System.Windows.Forms.TextBox();
            this.ulabel6Password = new System.Windows.Forms.Label();
            this.ulabel5EMail = new System.Windows.Forms.Label();
            this.ulabel4PhNo = new System.Windows.Forms.Label();
            this.ulabel3LoginName = new System.Windows.Forms.Label();
            this.ulabel2FirstName = new System.Windows.Forms.Label();
            this.ulabel1Name = new System.Windows.Forms.Label();
            this.ubuttonAdd = new System.Windows.Forms.Button();
            this.utabPageUserUpdate = new System.Windows.Forms.TabPage();
            this.utextBox7updateId = new System.Windows.Forms.TextBox();
            this.ulabel7updateId = new System.Windows.Forms.Label();
            this.utextBox1updatePassword = new System.Windows.Forms.TextBox();
            this.utextBox2updateEmail = new System.Windows.Forms.TextBox();
            this.utextBox3updatePhoneNo = new System.Windows.Forms.TextBox();
            this.utextBox4updateLoginName = new System.Windows.Forms.TextBox();
            this.utextBox5updateFirstName = new System.Windows.Forms.TextBox();
            this.utextBox6updateName = new System.Windows.Forms.TextBox();
            this.ulabel1updatePassword = new System.Windows.Forms.Label();
            this.ulabel2updateEmail = new System.Windows.Forms.Label();
            this.ulabel3updatePhoneNo = new System.Windows.Forms.Label();
            this.ulabel4updateLoginName = new System.Windows.Forms.Label();
            this.ulabel5updateFirstName = new System.Windows.Forms.Label();
            this.ulabel6updateName = new System.Windows.Forms.Label();
            this.ubuttonUpdate = new System.Windows.Forms.Button();
            this.utabPageUserDelete = new System.Windows.Forms.TabPage();
            this.ubuttonDelete = new System.Windows.Forms.Button();
            this.udataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.fbuttonLogout = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.ftextBoxPassword = new System.Windows.Forms.TextBox();
            this.flabelPassword = new System.Windows.Forms.Label();
            this.ftextBoxLoginName = new System.Windows.Forms.TextBox();
            this.flabelLoginName = new System.Windows.Forms.Label();
            this.fbuttonLogin = new System.Windows.Forms.Button();
            this.labelHeadingAMIO = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInMainHeading = new System.Windows.Forms.TableLayoutPanel();
            this.bindingSourceTopics = new System.Windows.Forms.BindingSource(this.components);
            this.ftableLayoutPanelForumMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.tabControlForumUsers.SuspendLayout();
            this.ftabPageForum.SuspendLayout();
            this.tableLayoutPanelForum.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fdataGridView1Topics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdataGridView2Replies)).BeginInit();
            this.utabPageUser.SuspendLayout();
            this.tableLayoutPanelUser.SuspendLayout();
            this.tabControlUserAddDelUpdate.SuspendLayout();
            this.utabPageUserAdd.SuspendLayout();
            this.utabPageUserUpdate.SuspendLayout();
            this.utabPageUserDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udataGridViewUsers)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelInMainHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopics)).BeginInit();
            this.ftableLayoutPanelForumMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.CurrentChanged += new System.EventHandler(this.bindingSourceUsers_CurrentChanged);
            // 
            // tabControlForumUsers
            // 
            this.tabControlForumUsers.Controls.Add(this.ftabPageForum);
            this.tabControlForumUsers.Controls.Add(this.utabPageUser);
            this.tabControlForumUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlForumUsers.Location = new System.Drawing.Point(3, 63);
            this.tabControlForumUsers.Name = "tabControlForumUsers";
            this.tabControlForumUsers.SelectedIndex = 0;
            this.tabControlForumUsers.Size = new System.Drawing.Size(1612, 758);
            this.tabControlForumUsers.TabIndex = 2;
            // 
            // ftabPageForum
            // 
            this.ftabPageForum.Controls.Add(this.ftableLayoutPanelForumMain);
            this.ftabPageForum.Controls.Add(this.tableLayoutPanelForum);
            this.ftabPageForum.Location = new System.Drawing.Point(4, 29);
            this.ftabPageForum.Name = "ftabPageForum";
            this.ftabPageForum.Padding = new System.Windows.Forms.Padding(3);
            this.ftabPageForum.Size = new System.Drawing.Size(1604, 725);
            this.ftabPageForum.TabIndex = 0;
            this.ftabPageForum.Text = "Forum";
            this.ftabPageForum.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelForum
            // 
            this.tableLayoutPanelForum.ColumnCount = 4;
            this.tableLayoutPanelForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForum.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelForum.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanelForum.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanelForum.Controls.Add(this.ftextBox1RubNameTopics, 1, 0);
            this.tableLayoutPanelForum.Controls.Add(this.fdataGridView1Topics, 1, 1);
            this.tableLayoutPanelForum.Controls.Add(this.ftextBoxTopicNameReplies, 3, 0);
            this.tableLayoutPanelForum.Controls.Add(this.fdataGridView2Replies, 3, 1);
            this.tableLayoutPanelForum.Location = new System.Drawing.Point(888, 292);
            this.tableLayoutPanelForum.Name = "tableLayoutPanelForum";
            this.tableLayoutPanelForum.RowCount = 3;
            this.tableLayoutPanelForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelForum.Size = new System.Drawing.Size(695, 412);
            this.tableLayoutPanelForum.TabIndex = 13;
            // 
            // flabelRubriques
            // 
            this.flabelRubriques.AutoSize = true;
            this.flabelRubriques.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flabelRubriques.Location = new System.Drawing.Point(3, 0);
            this.flabelRubriques.Name = "flabelRubriques";
            this.flabelRubriques.Size = new System.Drawing.Size(142, 38);
            this.flabelRubriques.TabIndex = 2;
            this.flabelRubriques.Text = "Rubriques";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rbutton1Dev, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbutton2Adre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbutton3Ques, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbutton5Galerie, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbutton4EspaceD, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 166);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // rbutton1Dev
            // 
            this.rbutton1Dev.Location = new System.Drawing.Point(3, 3);
            this.rbutton1Dev.Name = "rbutton1Dev";
            this.rbutton1Dev.Size = new System.Drawing.Size(152, 50);
            this.rbutton1Dev.TabIndex = 11;
            this.rbutton1Dev.Text = "Développement";
            this.rbutton1Dev.UseVisualStyleBackColor = true;
            this.rbutton1Dev.Click += new System.EventHandler(this.rbutton1Dev_Click);
            // 
            // rbutton2Adre
            // 
            this.rbutton2Adre.Location = new System.Drawing.Point(3, 83);
            this.rbutton2Adre.Name = "rbutton2Adre";
            this.rbutton2Adre.Size = new System.Drawing.Size(152, 50);
            this.rbutton2Adre.TabIndex = 6;
            this.rbutton2Adre.Text = "Adresses utiles";
            this.rbutton2Adre.UseVisualStyleBackColor = true;
            this.rbutton2Adre.Click += new System.EventHandler(this.rbutton2Adre_Click);
            // 
            // rbutton3Ques
            // 
            this.rbutton3Ques.Location = new System.Drawing.Point(3, 163);
            this.rbutton3Ques.Name = "rbutton3Ques";
            this.rbutton3Ques.Size = new System.Drawing.Size(152, 50);
            this.rbutton3Ques.TabIndex = 7;
            this.rbutton3Ques.Text = "Questions diverses";
            this.rbutton3Ques.UseVisualStyleBackColor = true;
            this.rbutton3Ques.Click += new System.EventHandler(this.rbutton3Ques_Click);
            // 
            // rbutton5Galerie
            // 
            this.rbutton5Galerie.Location = new System.Drawing.Point(3, 323);
            this.rbutton5Galerie.Name = "rbutton5Galerie";
            this.rbutton5Galerie.Size = new System.Drawing.Size(152, 50);
            this.rbutton5Galerie.TabIndex = 9;
            this.rbutton5Galerie.Text = "Galerie";
            this.rbutton5Galerie.UseVisualStyleBackColor = true;
            this.rbutton5Galerie.Click += new System.EventHandler(this.rbutton5Galerie_Click);
            // 
            // rbutton4EspaceD
            // 
            this.rbutton4EspaceD.Location = new System.Drawing.Point(3, 243);
            this.rbutton4EspaceD.Name = "rbutton4EspaceD";
            this.rbutton4EspaceD.Size = new System.Drawing.Size(152, 50);
            this.rbutton4EspaceD.TabIndex = 8;
            this.rbutton4EspaceD.Text = " Espace Détente";
            this.rbutton4EspaceD.UseVisualStyleBackColor = true;
            this.rbutton4EspaceD.Click += new System.EventHandler(this.rbutton4EspaceD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "token";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "roles";
            // 
            // ftextBox1RubNameTopics
            // 
            this.ftextBox1RubNameTopics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ftextBox1RubNameTopics.Location = new System.Drawing.Point(183, 3);
            this.ftextBox1RubNameTopics.Name = "ftextBox1RubNameTopics";
            this.ftextBox1RubNameTopics.ReadOnly = true;
            this.ftextBox1RubNameTopics.Size = new System.Drawing.Size(225, 27);
            this.ftextBox1RubNameTopics.TabIndex = 13;
            // 
            // fdataGridView1Topics
            // 
            this.fdataGridView1Topics.AllowUserToAddRows = false;
            this.fdataGridView1Topics.AllowUserToDeleteRows = false;
            this.fdataGridView1Topics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fdataGridView1Topics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdataGridView1Topics.Location = new System.Drawing.Point(183, 63);
            this.fdataGridView1Topics.Name = "fdataGridView1Topics";
            this.fdataGridView1Topics.ReadOnly = true;
            this.fdataGridView1Topics.RowHeadersWidth = 51;
            this.fdataGridView1Topics.RowTemplate.Height = 29;
            this.fdataGridView1Topics.Size = new System.Drawing.Size(225, 166);
            this.fdataGridView1Topics.TabIndex = 15;
            // 
            // ftextBoxTopicNameReplies
            // 
            this.ftextBoxTopicNameReplies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ftextBoxTopicNameReplies.Location = new System.Drawing.Point(439, 3);
            this.ftextBoxTopicNameReplies.Name = "ftextBoxTopicNameReplies";
            this.ftextBoxTopicNameReplies.ReadOnly = true;
            this.ftextBoxTopicNameReplies.Size = new System.Drawing.Size(253, 27);
            this.ftextBoxTopicNameReplies.TabIndex = 14;
            // 
            // fdataGridView2Replies
            // 
            this.fdataGridView2Replies.AllowUserToAddRows = false;
            this.fdataGridView2Replies.AllowUserToDeleteRows = false;
            this.fdataGridView2Replies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fdataGridView2Replies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdataGridView2Replies.Location = new System.Drawing.Point(439, 63);
            this.fdataGridView2Replies.Name = "fdataGridView2Replies";
            this.fdataGridView2Replies.ReadOnly = true;
            this.fdataGridView2Replies.RowHeadersWidth = 51;
            this.fdataGridView2Replies.RowTemplate.Height = 29;
            this.fdataGridView2Replies.Size = new System.Drawing.Size(253, 166);
            this.fdataGridView2Replies.TabIndex = 16;
            // 
            // utabPageUser
            // 
            this.utabPageUser.Controls.Add(this.tableLayoutPanelUser);
            this.utabPageUser.Location = new System.Drawing.Point(4, 29);
            this.utabPageUser.Name = "utabPageUser";
            this.utabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.utabPageUser.Size = new System.Drawing.Size(1604, 725);
            this.utabPageUser.TabIndex = 1;
            this.utabPageUser.Text = "Users";
            this.utabPageUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelUser
            // 
            this.tableLayoutPanelUser.ColumnCount = 2;
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanelUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUser.Controls.Add(this.tabControlUserAddDelUpdate, 0, 0);
            this.tableLayoutPanelUser.Controls.Add(this.udataGridViewUsers, 1, 0);
            this.tableLayoutPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUser.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUser.Name = "tableLayoutPanelUser";
            this.tableLayoutPanelUser.RowCount = 1;
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 719F));
            this.tableLayoutPanelUser.Size = new System.Drawing.Size(1598, 719);
            this.tableLayoutPanelUser.TabIndex = 2;
            // 
            // tabControlUserAddDelUpdate
            // 
            this.tabControlUserAddDelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlUserAddDelUpdate.Controls.Add(this.utabPageUserAdd);
            this.tabControlUserAddDelUpdate.Controls.Add(this.utabPageUserUpdate);
            this.tabControlUserAddDelUpdate.Controls.Add(this.utabPageUserDelete);
            this.tabControlUserAddDelUpdate.Location = new System.Drawing.Point(3, 254);
            this.tabControlUserAddDelUpdate.Name = "tabControlUserAddDelUpdate";
            this.tabControlUserAddDelUpdate.SelectedIndex = 0;
            this.tabControlUserAddDelUpdate.Size = new System.Drawing.Size(451, 462);
            this.tabControlUserAddDelUpdate.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlUserAddDelUpdate.TabIndex = 1;
            // 
            // utabPageUserAdd
            // 
            this.utabPageUserAdd.Controls.Add(this.utextBox6Password);
            this.utabPageUserAdd.Controls.Add(this.utextBox5EMail);
            this.utabPageUserAdd.Controls.Add(this.utextBox4PhNo);
            this.utabPageUserAdd.Controls.Add(this.utextBox3LoginName);
            this.utabPageUserAdd.Controls.Add(this.utextBox2FirstName);
            this.utabPageUserAdd.Controls.Add(this.utextBox1Name);
            this.utabPageUserAdd.Controls.Add(this.ulabel6Password);
            this.utabPageUserAdd.Controls.Add(this.ulabel5EMail);
            this.utabPageUserAdd.Controls.Add(this.ulabel4PhNo);
            this.utabPageUserAdd.Controls.Add(this.ulabel3LoginName);
            this.utabPageUserAdd.Controls.Add(this.ulabel2FirstName);
            this.utabPageUserAdd.Controls.Add(this.ulabel1Name);
            this.utabPageUserAdd.Controls.Add(this.ubuttonAdd);
            this.utabPageUserAdd.Location = new System.Drawing.Point(4, 29);
            this.utabPageUserAdd.Name = "utabPageUserAdd";
            this.utabPageUserAdd.Padding = new System.Windows.Forms.Padding(3);
            this.utabPageUserAdd.Size = new System.Drawing.Size(443, 429);
            this.utabPageUserAdd.TabIndex = 0;
            this.utabPageUserAdd.Text = "Add";
            this.utabPageUserAdd.UseVisualStyleBackColor = true;
            // 
            // utextBox6Password
            // 
            this.utextBox6Password.Location = new System.Drawing.Point(145, 286);
            this.utextBox6Password.Name = "utextBox6Password";
            this.utextBox6Password.Size = new System.Drawing.Size(238, 27);
            this.utextBox6Password.TabIndex = 12;
            this.utextBox6Password.Text = "password";
            // 
            // utextBox5EMail
            // 
            this.utextBox5EMail.Location = new System.Drawing.Point(145, 240);
            this.utextBox5EMail.Name = "utextBox5EMail";
            this.utextBox5EMail.Size = new System.Drawing.Size(238, 27);
            this.utextBox5EMail.TabIndex = 11;
            // 
            // utextBox4PhNo
            // 
            this.utextBox4PhNo.Location = new System.Drawing.Point(145, 190);
            this.utextBox4PhNo.Name = "utextBox4PhNo";
            this.utextBox4PhNo.Size = new System.Drawing.Size(238, 27);
            this.utextBox4PhNo.TabIndex = 10;
            // 
            // utextBox3LoginName
            // 
            this.utextBox3LoginName.Location = new System.Drawing.Point(145, 140);
            this.utextBox3LoginName.Name = "utextBox3LoginName";
            this.utextBox3LoginName.Size = new System.Drawing.Size(238, 27);
            this.utextBox3LoginName.TabIndex = 9;
            // 
            // utextBox2FirstName
            // 
            this.utextBox2FirstName.Location = new System.Drawing.Point(145, 92);
            this.utextBox2FirstName.Name = "utextBox2FirstName";
            this.utextBox2FirstName.Size = new System.Drawing.Size(238, 27);
            this.utextBox2FirstName.TabIndex = 8;
            // 
            // utextBox1Name
            // 
            this.utextBox1Name.Location = new System.Drawing.Point(145, 40);
            this.utextBox1Name.Name = "utextBox1Name";
            this.utextBox1Name.Size = new System.Drawing.Size(238, 27);
            this.utextBox1Name.TabIndex = 7;
            // 
            // ulabel6Password
            // 
            this.ulabel6Password.AutoSize = true;
            this.ulabel6Password.Location = new System.Drawing.Point(47, 289);
            this.ulabel6Password.Name = "ulabel6Password";
            this.ulabel6Password.Size = new System.Drawing.Size(70, 20);
            this.ulabel6Password.TabIndex = 6;
            this.ulabel6Password.Text = "Password";
            // 
            // ulabel5EMail
            // 
            this.ulabel5EMail.AutoSize = true;
            this.ulabel5EMail.Location = new System.Drawing.Point(47, 243);
            this.ulabel5EMail.Name = "ulabel5EMail";
            this.ulabel5EMail.Size = new System.Drawing.Size(46, 20);
            this.ulabel5EMail.TabIndex = 5;
            this.ulabel5EMail.Text = "Email";
            // 
            // ulabel4PhNo
            // 
            this.ulabel4PhNo.AutoSize = true;
            this.ulabel4PhNo.Location = new System.Drawing.Point(47, 193);
            this.ulabel4PhNo.Name = "ulabel4PhNo";
            this.ulabel4PhNo.Size = new System.Drawing.Size(71, 20);
            this.ulabel4PhNo.TabIndex = 4;
            this.ulabel4PhNo.Text = "Phone no";
            // 
            // ulabel3LoginName
            // 
            this.ulabel3LoginName.AutoSize = true;
            this.ulabel3LoginName.Location = new System.Drawing.Point(47, 140);
            this.ulabel3LoginName.Name = "ulabel3LoginName";
            this.ulabel3LoginName.Size = new System.Drawing.Size(87, 20);
            this.ulabel3LoginName.TabIndex = 3;
            this.ulabel3LoginName.Text = "Login name";
            // 
            // ulabel2FirstName
            // 
            this.ulabel2FirstName.AutoSize = true;
            this.ulabel2FirstName.Location = new System.Drawing.Point(47, 92);
            this.ulabel2FirstName.Name = "ulabel2FirstName";
            this.ulabel2FirstName.Size = new System.Drawing.Size(77, 20);
            this.ulabel2FirstName.TabIndex = 2;
            this.ulabel2FirstName.Text = "First name";
            // 
            // ulabel1Name
            // 
            this.ulabel1Name.AutoSize = true;
            this.ulabel1Name.Location = new System.Drawing.Point(47, 43);
            this.ulabel1Name.Name = "ulabel1Name";
            this.ulabel1Name.Size = new System.Drawing.Size(49, 20);
            this.ulabel1Name.TabIndex = 1;
            this.ulabel1Name.Text = "Name";
            // 
            // ubuttonAdd
            // 
            this.ubuttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuttonAdd.Location = new System.Drawing.Point(289, 363);
            this.ubuttonAdd.Name = "ubuttonAdd";
            this.ubuttonAdd.Size = new System.Drawing.Size(94, 29);
            this.ubuttonAdd.TabIndex = 0;
            this.ubuttonAdd.Text = "Add";
            this.ubuttonAdd.UseVisualStyleBackColor = true;
            this.ubuttonAdd.Click += new System.EventHandler(this.ubuttonAdd_Click);
            // 
            // utabPageUserUpdate
            // 
            this.utabPageUserUpdate.Controls.Add(this.utextBox7updateId);
            this.utabPageUserUpdate.Controls.Add(this.ulabel7updateId);
            this.utabPageUserUpdate.Controls.Add(this.utextBox1updatePassword);
            this.utabPageUserUpdate.Controls.Add(this.utextBox2updateEmail);
            this.utabPageUserUpdate.Controls.Add(this.utextBox3updatePhoneNo);
            this.utabPageUserUpdate.Controls.Add(this.utextBox4updateLoginName);
            this.utabPageUserUpdate.Controls.Add(this.utextBox5updateFirstName);
            this.utabPageUserUpdate.Controls.Add(this.utextBox6updateName);
            this.utabPageUserUpdate.Controls.Add(this.ulabel1updatePassword);
            this.utabPageUserUpdate.Controls.Add(this.ulabel2updateEmail);
            this.utabPageUserUpdate.Controls.Add(this.ulabel3updatePhoneNo);
            this.utabPageUserUpdate.Controls.Add(this.ulabel4updateLoginName);
            this.utabPageUserUpdate.Controls.Add(this.ulabel5updateFirstName);
            this.utabPageUserUpdate.Controls.Add(this.ulabel6updateName);
            this.utabPageUserUpdate.Controls.Add(this.ubuttonUpdate);
            this.utabPageUserUpdate.Location = new System.Drawing.Point(4, 29);
            this.utabPageUserUpdate.Name = "utabPageUserUpdate";
            this.utabPageUserUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.utabPageUserUpdate.Size = new System.Drawing.Size(443, 429);
            this.utabPageUserUpdate.TabIndex = 1;
            this.utabPageUserUpdate.Text = "Update";
            this.utabPageUserUpdate.UseVisualStyleBackColor = true;
            // 
            // utextBox7updateId
            // 
            this.utextBox7updateId.Location = new System.Drawing.Point(149, 58);
            this.utextBox7updateId.Name = "utextBox7updateId";
            this.utextBox7updateId.ReadOnly = true;
            this.utextBox7updateId.Size = new System.Drawing.Size(70, 27);
            this.utextBox7updateId.TabIndex = 27;
            // 
            // ulabel7updateId
            // 
            this.ulabel7updateId.AutoSize = true;
            this.ulabel7updateId.Location = new System.Drawing.Point(51, 61);
            this.ulabel7updateId.Name = "ulabel7updateId";
            this.ulabel7updateId.Size = new System.Drawing.Size(22, 20);
            this.ulabel7updateId.TabIndex = 26;
            this.ulabel7updateId.Text = "Id";
            // 
            // utextBox1updatePassword
            // 
            this.utextBox1updatePassword.Location = new System.Drawing.Point(149, 363);
            this.utextBox1updatePassword.Name = "utextBox1updatePassword";
            this.utextBox1updatePassword.Size = new System.Drawing.Size(238, 27);
            this.utextBox1updatePassword.TabIndex = 25;
            this.utextBox1updatePassword.Text = "password";
            // 
            // utextBox2updateEmail
            // 
            this.utextBox2updateEmail.Location = new System.Drawing.Point(149, 317);
            this.utextBox2updateEmail.Name = "utextBox2updateEmail";
            this.utextBox2updateEmail.Size = new System.Drawing.Size(238, 27);
            this.utextBox2updateEmail.TabIndex = 24;
            // 
            // utextBox3updatePhoneNo
            // 
            this.utextBox3updatePhoneNo.Location = new System.Drawing.Point(149, 267);
            this.utextBox3updatePhoneNo.Name = "utextBox3updatePhoneNo";
            this.utextBox3updatePhoneNo.Size = new System.Drawing.Size(238, 27);
            this.utextBox3updatePhoneNo.TabIndex = 23;
            // 
            // utextBox4updateLoginName
            // 
            this.utextBox4updateLoginName.Location = new System.Drawing.Point(149, 217);
            this.utextBox4updateLoginName.Name = "utextBox4updateLoginName";
            this.utextBox4updateLoginName.Size = new System.Drawing.Size(238, 27);
            this.utextBox4updateLoginName.TabIndex = 22;
            // 
            // utextBox5updateFirstName
            // 
            this.utextBox5updateFirstName.Location = new System.Drawing.Point(149, 169);
            this.utextBox5updateFirstName.Name = "utextBox5updateFirstName";
            this.utextBox5updateFirstName.Size = new System.Drawing.Size(238, 27);
            this.utextBox5updateFirstName.TabIndex = 21;
            // 
            // utextBox6updateName
            // 
            this.utextBox6updateName.Location = new System.Drawing.Point(149, 117);
            this.utextBox6updateName.Name = "utextBox6updateName";
            this.utextBox6updateName.Size = new System.Drawing.Size(238, 27);
            this.utextBox6updateName.TabIndex = 20;
            // 
            // ulabel1updatePassword
            // 
            this.ulabel1updatePassword.AutoSize = true;
            this.ulabel1updatePassword.Location = new System.Drawing.Point(51, 366);
            this.ulabel1updatePassword.Name = "ulabel1updatePassword";
            this.ulabel1updatePassword.Size = new System.Drawing.Size(70, 20);
            this.ulabel1updatePassword.TabIndex = 19;
            this.ulabel1updatePassword.Text = "Password";
            // 
            // ulabel2updateEmail
            // 
            this.ulabel2updateEmail.AutoSize = true;
            this.ulabel2updateEmail.Location = new System.Drawing.Point(51, 320);
            this.ulabel2updateEmail.Name = "ulabel2updateEmail";
            this.ulabel2updateEmail.Size = new System.Drawing.Size(46, 20);
            this.ulabel2updateEmail.TabIndex = 18;
            this.ulabel2updateEmail.Text = "Email";
            // 
            // ulabel3updatePhoneNo
            // 
            this.ulabel3updatePhoneNo.AutoSize = true;
            this.ulabel3updatePhoneNo.Location = new System.Drawing.Point(51, 270);
            this.ulabel3updatePhoneNo.Name = "ulabel3updatePhoneNo";
            this.ulabel3updatePhoneNo.Size = new System.Drawing.Size(71, 20);
            this.ulabel3updatePhoneNo.TabIndex = 17;
            this.ulabel3updatePhoneNo.Text = "Phone no";
            // 
            // ulabel4updateLoginName
            // 
            this.ulabel4updateLoginName.AutoSize = true;
            this.ulabel4updateLoginName.Location = new System.Drawing.Point(51, 217);
            this.ulabel4updateLoginName.Name = "ulabel4updateLoginName";
            this.ulabel4updateLoginName.Size = new System.Drawing.Size(87, 20);
            this.ulabel4updateLoginName.TabIndex = 16;
            this.ulabel4updateLoginName.Text = "Login name";
            // 
            // ulabel5updateFirstName
            // 
            this.ulabel5updateFirstName.AutoSize = true;
            this.ulabel5updateFirstName.Location = new System.Drawing.Point(51, 169);
            this.ulabel5updateFirstName.Name = "ulabel5updateFirstName";
            this.ulabel5updateFirstName.Size = new System.Drawing.Size(77, 20);
            this.ulabel5updateFirstName.TabIndex = 15;
            this.ulabel5updateFirstName.Text = "First name";
            // 
            // ulabel6updateName
            // 
            this.ulabel6updateName.AutoSize = true;
            this.ulabel6updateName.Location = new System.Drawing.Point(51, 120);
            this.ulabel6updateName.Name = "ulabel6updateName";
            this.ulabel6updateName.Size = new System.Drawing.Size(49, 20);
            this.ulabel6updateName.TabIndex = 14;
            this.ulabel6updateName.Text = "Name";
            // 
            // ubuttonUpdate
            // 
            this.ubuttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuttonUpdate.Location = new System.Drawing.Point(293, 58);
            this.ubuttonUpdate.Name = "ubuttonUpdate";
            this.ubuttonUpdate.Size = new System.Drawing.Size(94, 29);
            this.ubuttonUpdate.TabIndex = 13;
            this.ubuttonUpdate.Text = "Update";
            this.ubuttonUpdate.UseVisualStyleBackColor = true;
            this.ubuttonUpdate.Click += new System.EventHandler(this.ubuttonUpdate_Click);
            // 
            // utabPageUserDelete
            // 
            this.utabPageUserDelete.Controls.Add(this.ubuttonDelete);
            this.utabPageUserDelete.Location = new System.Drawing.Point(4, 29);
            this.utabPageUserDelete.Name = "utabPageUserDelete";
            this.utabPageUserDelete.Padding = new System.Windows.Forms.Padding(3);
            this.utabPageUserDelete.Size = new System.Drawing.Size(443, 429);
            this.utabPageUserDelete.TabIndex = 2;
            this.utabPageUserDelete.Text = "Delete";
            this.utabPageUserDelete.UseVisualStyleBackColor = true;
            // 
            // ubuttonDelete
            // 
            this.ubuttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuttonDelete.Location = new System.Drawing.Point(173, 198);
            this.ubuttonDelete.Name = "ubuttonDelete";
            this.ubuttonDelete.Size = new System.Drawing.Size(94, 29);
            this.ubuttonDelete.TabIndex = 0;
            this.ubuttonDelete.Text = "Delete";
            this.ubuttonDelete.UseVisualStyleBackColor = true;
            this.ubuttonDelete.Click += new System.EventHandler(this.ubuttonDelete_Click);
            // 
            // udataGridViewUsers
            // 
            this.udataGridViewUsers.AllowUserToAddRows = false;
            this.udataGridViewUsers.AllowUserToDeleteRows = false;
            this.udataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.udataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udataGridViewUsers.Location = new System.Drawing.Point(503, 3);
            this.udataGridViewUsers.Name = "udataGridViewUsers";
            this.udataGridViewUsers.ReadOnly = true;
            this.udataGridViewUsers.RowHeadersWidth = 51;
            this.udataGridViewUsers.RowTemplate.Height = 29;
            this.udataGridViewUsers.Size = new System.Drawing.Size(1092, 713);
            this.udataGridViewUsers.TabIndex = 0;
            // 
            // fbuttonLogout
            // 
            this.fbuttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fbuttonLogout.Location = new System.Drawing.Point(1514, 10);
            this.fbuttonLogout.Name = "fbuttonLogout";
            this.fbuttonLogout.Size = new System.Drawing.Size(95, 33);
            this.fbuttonLogout.TabIndex = 1;
            this.fbuttonLogout.Text = "Logout";
            this.fbuttonLogout.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelLogin.Controls.Add(this.ftextBoxPassword);
            this.panelLogin.Controls.Add(this.flabelPassword);
            this.panelLogin.Controls.Add(this.ftextBoxLoginName);
            this.panelLogin.Controls.Add(this.flabelLoginName);
            this.panelLogin.Controls.Add(this.fbuttonLogin);
            this.panelLogin.Location = new System.Drawing.Point(796, 5);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(683, 44);
            this.panelLogin.TabIndex = 0;
            // 
            // ftextBoxPassword
            // 
            this.ftextBoxPassword.Location = new System.Drawing.Point(357, 8);
            this.ftextBoxPassword.Name = "ftextBoxPassword";
            this.ftextBoxPassword.Size = new System.Drawing.Size(187, 27);
            this.ftextBoxPassword.TabIndex = 5;
            this.ftextBoxPassword.Text = "password";
            // 
            // flabelPassword
            // 
            this.flabelPassword.AutoSize = true;
            this.flabelPassword.Location = new System.Drawing.Point(281, 13);
            this.flabelPassword.Name = "flabelPassword";
            this.flabelPassword.Size = new System.Drawing.Size(70, 20);
            this.flabelPassword.TabIndex = 3;
            this.flabelPassword.Text = "Password";
            // 
            // ftextBoxLoginName
            // 
            this.ftextBoxLoginName.Location = new System.Drawing.Point(96, 10);
            this.ftextBoxLoginName.Name = "ftextBoxLoginName";
            this.ftextBoxLoginName.Size = new System.Drawing.Size(164, 27);
            this.ftextBoxLoginName.TabIndex = 4;
            this.ftextBoxLoginName.Text = "Leo2";
            // 
            // flabelLoginName
            // 
            this.flabelLoginName.AutoSize = true;
            this.flabelLoginName.Location = new System.Drawing.Point(3, 13);
            this.flabelLoginName.Name = "flabelLoginName";
            this.flabelLoginName.Size = new System.Drawing.Size(87, 20);
            this.flabelLoginName.TabIndex = 2;
            this.flabelLoginName.Text = "Login name";
            // 
            // fbuttonLogin
            // 
            this.fbuttonLogin.Location = new System.Drawing.Point(566, 7);
            this.fbuttonLogin.Name = "fbuttonLogin";
            this.fbuttonLogin.Size = new System.Drawing.Size(107, 33);
            this.fbuttonLogin.TabIndex = 0;
            this.fbuttonLogin.Text = "Login";
            this.fbuttonLogin.UseVisualStyleBackColor = true;
            this.fbuttonLogin.Click += new System.EventHandler(this.fbuttonLogin_Click);
            // 
            // labelHeadingAMIO
            // 
            this.labelHeadingAMIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadingAMIO.AutoSize = true;
            this.labelHeadingAMIO.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeadingAMIO.Location = new System.Drawing.Point(158, 0);
            this.labelHeadingAMIO.Name = "labelHeadingAMIO";
            this.labelHeadingAMIO.Size = new System.Drawing.Size(440, 45);
            this.labelHeadingAMIO.TabIndex = 0;
            this.labelHeadingAMIO.Text = "Forum AMIO Développement";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.tabControlForumUsers, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelInMainHeading, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1618, 824);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanelInMainHeading
            // 
            this.tableLayoutPanelInMainHeading.ColumnCount = 4;
            this.tableLayoutPanelInMainHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInMainHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanelInMainHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInMainHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelInMainHeading.Controls.Add(this.labelHeadingAMIO, 1, 0);
            this.tableLayoutPanelInMainHeading.Controls.Add(this.panelLogin, 2, 0);
            this.tableLayoutPanelInMainHeading.Controls.Add(this.fbuttonLogout, 3, 0);
            this.tableLayoutPanelInMainHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInMainHeading.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInMainHeading.Name = "tableLayoutPanelInMainHeading";
            this.tableLayoutPanelInMainHeading.RowCount = 1;
            this.tableLayoutPanelInMainHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInMainHeading.Size = new System.Drawing.Size(1612, 54);
            this.tableLayoutPanelInMainHeading.TabIndex = 3;
            // 
            // ftableLayoutPanelForumMain
            // 
            this.ftableLayoutPanelForumMain.ColumnCount = 1;
            this.ftableLayoutPanelForumMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ftableLayoutPanelForumMain.Controls.Add(this.flabelRubriques, 0, 0);
            this.ftableLayoutPanelForumMain.Location = new System.Drawing.Point(25, 39);
            this.ftableLayoutPanelForumMain.Name = "ftableLayoutPanelForumMain";
            this.ftableLayoutPanelForumMain.RowCount = 6;
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ftableLayoutPanelForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ftableLayoutPanelForumMain.Size = new System.Drawing.Size(814, 529);
            this.ftableLayoutPanelForumMain.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 824);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.tabControlForumUsers.ResumeLayout(false);
            this.ftabPageForum.ResumeLayout(false);
            this.tableLayoutPanelForum.ResumeLayout(false);
            this.tableLayoutPanelForum.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fdataGridView1Topics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdataGridView2Replies)).EndInit();
            this.utabPageUser.ResumeLayout(false);
            this.tableLayoutPanelUser.ResumeLayout(false);
            this.tabControlUserAddDelUpdate.ResumeLayout(false);
            this.utabPageUserAdd.ResumeLayout(false);
            this.utabPageUserAdd.PerformLayout();
            this.utabPageUserUpdate.ResumeLayout(false);
            this.utabPageUserUpdate.PerformLayout();
            this.utabPageUserDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udataGridViewUsers)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelInMainHeading.ResumeLayout(false);
            this.tableLayoutPanelInMainHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopics)).EndInit();
            this.ftableLayoutPanelForumMain.ResumeLayout(false);
            this.ftableLayoutPanelForumMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.TabControl tabControlForumUsers;
        private System.Windows.Forms.TabPage ftabPageForum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForum;
        private System.Windows.Forms.Label flabelRubriques;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rbutton1Dev;
        private System.Windows.Forms.Button rbutton2Adre;
        private System.Windows.Forms.Button rbutton3Ques;
        private System.Windows.Forms.Button rbutton5Galerie;
        private System.Windows.Forms.Button rbutton4EspaceD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button fbuttonLogout;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox ftextBoxPassword;
        private System.Windows.Forms.Label flabelPassword;
        private System.Windows.Forms.TextBox ftextBoxLoginName;
        private System.Windows.Forms.Label flabelLoginName;
        private System.Windows.Forms.Button fbuttonLogin;
        private System.Windows.Forms.TabPage utabPageUser;
        private System.Windows.Forms.TabControl tabControlUserAddDelUpdate;
        private System.Windows.Forms.TabPage utabPageUserAdd;
        private System.Windows.Forms.TextBox utextBox6Password;
        private System.Windows.Forms.TextBox utextBox5EMail;
        private System.Windows.Forms.TextBox utextBox4PhNo;
        private System.Windows.Forms.TextBox utextBox3LoginName;
        private System.Windows.Forms.TextBox utextBox2FirstName;
        private System.Windows.Forms.TextBox utextBox1Name;
        private System.Windows.Forms.Label ulabel6Password;
        private System.Windows.Forms.Label ulabel5EMail;
        private System.Windows.Forms.Label ulabel4PhNo;
        private System.Windows.Forms.Label ulabel3LoginName;
        private System.Windows.Forms.Label ulabel2FirstName;
        private System.Windows.Forms.Label ulabel1Name;
        private System.Windows.Forms.Button ubuttonAdd;
        private System.Windows.Forms.TabPage utabPageUserUpdate;
        private System.Windows.Forms.TextBox utextBox7updateId;
        private System.Windows.Forms.Label ulabel7updateId;
        private System.Windows.Forms.TextBox utextBox1updatePassword;
        private System.Windows.Forms.TextBox utextBox2updateEmail;
        private System.Windows.Forms.TextBox utextBox3updatePhoneNo;
        private System.Windows.Forms.TextBox utextBox4updateLoginName;
        private System.Windows.Forms.TextBox utextBox5updateFirstName;
        private System.Windows.Forms.TextBox utextBox6updateName;
        private System.Windows.Forms.Label ulabel1updatePassword;
        private System.Windows.Forms.Label ulabel2updateEmail;
        private System.Windows.Forms.Label ulabel3updatePhoneNo;
        private System.Windows.Forms.Label ulabel4updateLoginName;
        private System.Windows.Forms.Label ulabel5updateFirstName;
        private System.Windows.Forms.Label ulabel6updateName;
        private System.Windows.Forms.Button ubuttonUpdate;
        private System.Windows.Forms.TabPage utabPageUserDelete;
        private System.Windows.Forms.Button ubuttonDelete;
        private System.Windows.Forms.DataGridView udataGridViewUsers;
        private System.Windows.Forms.Label labelHeadingAMIO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInMainHeading;
        private System.Windows.Forms.TextBox ftextBoxTopicNameReplies;
        private System.Windows.Forms.TextBox ftextBox1RubNameTopics;
        private System.Windows.Forms.DataGridView fdataGridView1Topics;
        private System.Windows.Forms.DataGridView fdataGridView2Replies;
        private System.Windows.Forms.BindingSource bindingSourceTopics;
        private System.Windows.Forms.TableLayoutPanel ftableLayoutPanelForumMain;
    }
}

