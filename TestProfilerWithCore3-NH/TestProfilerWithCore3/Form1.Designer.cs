using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TestProfilerWithCore3.Load;

namespace TestProfilerWithCore3
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.asyncButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NHbuttonAdd = new System.Windows.Forms.Button();
            this.NHbuttonGet = new System.Windows.Forms.Button();
            this.NHGetBlogsCount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NHButtonRawQuery = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NHbuttonGetById = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NHbuttonUpdate = new System.Windows.Forms.Button();
            this.TextBoxBlogId = new System.Windows.Forms.TextBox();
            this.NHbuttonDelete = new System.Windows.Forms.Button();
            this.NHGetBlogFromPost = new System.Windows.Forms.Button();
            this.buttonSQLConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSO_6 = new System.Windows.Forms.CheckBox();
            this.checkBoxSO_5 = new System.Windows.Forms.CheckBox();
            this.labelSO_6 = new System.Windows.Forms.Label();
            this.labelSO_5 = new System.Windows.Forms.Label();
            this.textBoxParamSO_6 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_6 = new System.Windows.Forms.TextBox();
            this.textBoxParamSO_5 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_5 = new System.Windows.Forms.TextBox();
            this.checkBoxSO_4 = new System.Windows.Forms.CheckBox();
            this.checkBoxSO_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSO_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSO_1 = new System.Windows.Forms.CheckBox();
            this.labelSO_4 = new System.Windows.Forms.Label();
            this.labelSO_3 = new System.Windows.Forms.Label();
            this.labelSO_2 = new System.Windows.Forms.Label();
            this.labelSO_1 = new System.Windows.Forms.Label();
            this.labelSO_0 = new System.Windows.Forms.Label();
            this.textBoxParamSO_4 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_4 = new System.Windows.Forms.TextBox();
            this.textBoxParamSO_3 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_3 = new System.Windows.Forms.TextBox();
            this.checkBoxSO_0 = new System.Windows.Forms.CheckBox();
            this.textBoxParamSO_2 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_2 = new System.Windows.Forms.TextBox();
            this.textBoxParamSO_1 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_1 = new System.Windows.Forms.TextBox();
            this.textBoxParamSO_0 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsSO_0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNH_3 = new System.Windows.Forms.Label();
            this.labelNH_2 = new System.Windows.Forms.Label();
            this.labelNH_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNH_0 = new System.Windows.Forms.Label();
            this.textBoxParamNH_3 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsNH_3 = new System.Windows.Forms.TextBox();
            this.checkBoxNH_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxNH_0 = new System.Windows.Forms.CheckBox();
            this.textBoxParamNH_2 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsNH_2 = new System.Windows.Forms.TextBox();
            this.checkBoxNH_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxNH_1 = new System.Windows.Forms.CheckBox();
            this.textBoxParamNH_1 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsNH_1 = new System.Windows.Forms.TextBox();
            this.textBoxParamNH_0 = new System.Windows.Forms.TextBox();
            this.textBoxThreadsNH_0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (92)))), ((int) (((byte) (139)))));
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSQLConnect);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 40;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (135)))), ((int) (((byte) (166)))));
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.GoButton);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2MinSize = 600;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(916, 643);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 55);
            this.label7.TabIndex = 26;
            this.label7.Text = "Basics";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))),
                ((int) (((byte) (215)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.asyncButton);
            this.panel4.Location = new System.Drawing.Point(24, 480);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 44);
            this.panel4.TabIndex = 25;
            // 
            // asyncButton
            // 
            this.asyncButton.BackColor = System.Drawing.Color.LightSalmon;
            this.asyncButton.Location = new System.Drawing.Point(4, 5);
            this.asyncButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(250, 30);
            this.asyncButton.TabIndex = 0;
            this.asyncButton.Text = "NH - Async";
            this.asyncButton.UseVisualStyleBackColor = false;
            this.asyncButton.Click += new System.EventHandler(this.asyncButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))),
                ((int) (((byte) (215)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NHbuttonAdd);
            this.panel3.Controls.Add(this.NHbuttonGet);
            this.panel3.Controls.Add(this.NHGetBlogsCount);
            this.panel3.Location = new System.Drawing.Point(24, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 113);
            this.panel3.TabIndex = 24;
            // 
            // NHbuttonAdd
            // 
            this.NHbuttonAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonAdd.Location = new System.Drawing.Point(4, 3);
            this.NHbuttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHbuttonAdd.Name = "NHbuttonAdd";
            this.NHbuttonAdd.Size = new System.Drawing.Size(250, 30);
            this.NHbuttonAdd.TabIndex = 1;
            this.NHbuttonAdd.Text = "NH - Add new Blog";
            this.NHbuttonAdd.UseVisualStyleBackColor = false;
            this.NHbuttonAdd.Click += new System.EventHandler(this.NHbuttonAdd_Click);
            // 
            // NHbuttonGet
            // 
            this.NHbuttonGet.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonGet.Location = new System.Drawing.Point(4, 75);
            this.NHbuttonGet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHbuttonGet.Name = "NHbuttonGet";
            this.NHbuttonGet.Size = new System.Drawing.Size(250, 30);
            this.NHbuttonGet.TabIndex = 3;
            this.NHbuttonGet.Text = "NH - Get all Blogs";
            this.NHbuttonGet.UseVisualStyleBackColor = false;
            this.NHbuttonGet.Click += new System.EventHandler(this.NHbuttonGetAllBlogs_Click);
            // 
            // NHGetBlogsCount
            // 
            this.NHGetBlogsCount.BackColor = System.Drawing.Color.LightSalmon;
            this.NHGetBlogsCount.Location = new System.Drawing.Point(4, 39);
            this.NHGetBlogsCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHGetBlogsCount.Name = "NHGetBlogsCount";
            this.NHGetBlogsCount.Size = new System.Drawing.Size(250, 30);
            this.NHGetBlogsCount.TabIndex = 8;
            this.NHGetBlogsCount.Text = "NH - Get Blogs Count - with CreateQuery\r\n";
            this.NHGetBlogsCount.UseVisualStyleBackColor = false;
            this.NHGetBlogsCount.Click += new System.EventHandler(this.NHGetBlogsCount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (157)))), ((int) (((byte) (157)))),
                ((int) (((byte) (157)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NHButtonRawQuery);
            this.panel2.Controls.Add(this.QueryTextBox);
            this.panel2.Location = new System.Drawing.Point(24, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 102);
            this.panel2.TabIndex = 23;
            // 
            // NHButtonRawQuery
            // 
            this.NHButtonRawQuery.BackColor = System.Drawing.Color.LightSalmon;
            this.NHButtonRawQuery.Location = new System.Drawing.Point(4, 3);
            this.NHButtonRawQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHButtonRawQuery.Name = "NHButtonRawQuery";
            this.NHButtonRawQuery.Size = new System.Drawing.Size(250, 30);
            this.NHButtonRawQuery.TabIndex = 9;
            this.NHButtonRawQuery.Text = "NH - HQL Query on Blogs Table";
            this.NHButtonRawQuery.UseVisualStyleBackColor = false;
            this.NHButtonRawQuery.Click += new System.EventHandler(this.NHButtonRawQuery_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(4, 39);
            this.QueryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(250, 52);
            this.QueryTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NHbuttonGetById);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NHbuttonUpdate);
            this.panel1.Controls.Add(this.TextBoxBlogId);
            this.panel1.Controls.Add(this.NHbuttonDelete);
            this.panel1.Controls.Add(this.NHGetBlogFromPost);
            this.panel1.Location = new System.Drawing.Point(24, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 170);
            this.panel1.TabIndex = 22;
            // 
            // NHbuttonGetById
            // 
            this.NHbuttonGetById.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonGetById.Location = new System.Drawing.Point(4, 3);
            this.NHbuttonGetById.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHbuttonGetById.Name = "NHbuttonGetById";
            this.NHbuttonGetById.Size = new System.Drawing.Size(250, 30);
            this.NHbuttonGetById.TabIndex = 4;
            this.NHbuttonGetById.Text = "NH - Get Blog by ID\r\n";
            this.NHbuttonGetById.UseVisualStyleBackColor = false;
            this.NHbuttonGetById.Click += new System.EventHandler(this.NHbuttonGetById_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Id:";
            // 
            // NHbuttonUpdate
            // 
            this.NHbuttonUpdate.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonUpdate.Location = new System.Drawing.Point(4, 35);
            this.NHbuttonUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHbuttonUpdate.Name = "NHbuttonUpdate";
            this.NHbuttonUpdate.Size = new System.Drawing.Size(250, 30);
            this.NHbuttonUpdate.TabIndex = 4;
            this.NHbuttonUpdate.Text = "NH - Update \'Created At\' column";
            this.NHbuttonUpdate.UseVisualStyleBackColor = false;
            this.NHbuttonUpdate.Click += new System.EventHandler(this.NHbuttonUpdate_Click);
            // 
            // TextBoxBlogId
            // 
            this.TextBoxBlogId.Location = new System.Drawing.Point(80, 140);
            this.TextBoxBlogId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxBlogId.Name = "TextBoxBlogId";
            this.TextBoxBlogId.Size = new System.Drawing.Size(84, 23);
            this.TextBoxBlogId.TabIndex = 5;
            // 
            // NHbuttonDelete
            // 
            this.NHbuttonDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonDelete.Location = new System.Drawing.Point(4, 72);
            this.NHbuttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHbuttonDelete.Name = "NHbuttonDelete";
            this.NHbuttonDelete.Size = new System.Drawing.Size(250, 30);
            this.NHbuttonDelete.TabIndex = 6;
            this.NHbuttonDelete.Text = "NH - Delete Blog\r\n";
            this.NHbuttonDelete.UseVisualStyleBackColor = false;
            this.NHbuttonDelete.Click += new System.EventHandler(this.NHbuttonDelete_Click);
            // 
            // NHGetBlogFromPost
            // 
            this.NHGetBlogFromPost.BackColor = System.Drawing.Color.LightSalmon;
            this.NHGetBlogFromPost.Location = new System.Drawing.Point(4, 107);
            this.NHGetBlogFromPost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NHGetBlogFromPost.Name = "NHGetBlogFromPost";
            this.NHGetBlogFromPost.Size = new System.Drawing.Size(250, 30);
            this.NHGetBlogFromPost.TabIndex = 7;
            this.NHGetBlogFromPost.Text = "NH - Get Blog from Post";
            this.NHGetBlogFromPost.UseVisualStyleBackColor = false;
            this.NHGetBlogFromPost.Click += new System.EventHandler(this.NHGetBlogFromPost_Click);
            // 
            // buttonSQLConnect
            // 
            this.buttonSQLConnect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSQLConnect.Location = new System.Drawing.Point(24, 528);
            this.buttonSQLConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSQLConnect.Name = "buttonSQLConnect";
            this.buttonSQLConnect.Size = new System.Drawing.Size(266, 32);
            this.buttonSQLConnect.TabIndex = 21;
            this.buttonSQLConnect.Text = "Connect with SqlConnection\r\n";
            this.buttonSQLConnect.UseVisualStyleBackColor = false;
            this.buttonSQLConnect.Click += new System.EventHandler(this.buttonSQLConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSO_6);
            this.groupBox2.Controls.Add(this.checkBoxSO_5);
            this.groupBox2.Controls.Add(this.labelSO_6);
            this.groupBox2.Controls.Add(this.labelSO_5);
            this.groupBox2.Controls.Add(this.textBoxParamSO_6);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_6);
            this.groupBox2.Controls.Add(this.textBoxParamSO_5);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_5);
            this.groupBox2.Controls.Add(this.checkBoxSO_4);
            this.groupBox2.Controls.Add(this.checkBoxSO_3);
            this.groupBox2.Controls.Add(this.checkBoxSO_2);
            this.groupBox2.Controls.Add(this.checkBoxSO_1);
            this.groupBox2.Controls.Add(this.labelSO_4);
            this.groupBox2.Controls.Add(this.labelSO_3);
            this.groupBox2.Controls.Add(this.labelSO_2);
            this.groupBox2.Controls.Add(this.labelSO_1);
            this.groupBox2.Controls.Add(this.labelSO_0);
            this.groupBox2.Controls.Add(this.textBoxParamSO_4);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_4);
            this.groupBox2.Controls.Add(this.textBoxParamSO_3);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_3);
            this.groupBox2.Controls.Add(this.checkBoxSO_0);
            this.groupBox2.Controls.Add(this.textBoxParamSO_2);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_2);
            this.groupBox2.Controls.Add(this.textBoxParamSO_1);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_1);
            this.groupBox2.Controls.Add(this.textBoxParamSO_0);
            this.groupBox2.Controls.Add(this.textBoxThreadsSO_0);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.Location = new System.Drawing.Point(59, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(622, 264);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " On SO Database ";
            // 
            // checkBoxSO_6
            // 
            this.checkBoxSO_6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_6.Location = new System.Drawing.Point(24, 219);
            this.checkBoxSO_6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_6.Name = "checkBoxSO_6";
            this.checkBoxSO_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_6.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_6.TabIndex = 108;
            this.checkBoxSO_6.Text = "Load Scenario #6";
            this.checkBoxSO_6.UseVisualStyleBackColor = true;
            // 
            // checkBoxSO_5
            // 
            this.checkBoxSO_5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_5.Location = new System.Drawing.Point(24, 189);
            this.checkBoxSO_5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_5.Name = "checkBoxSO_5";
            this.checkBoxSO_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_5.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_5.TabIndex = 107;
            this.checkBoxSO_5.Text = "Load Scenario #5";
            this.checkBoxSO_5.UseVisualStyleBackColor = true;
            // 
            // labelSO_6
            // 
            this.labelSO_6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_6.Location = new System.Drawing.Point(421, 223);
            this.labelSO_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_6.Name = "labelSO_6";
            this.labelSO_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_6.Size = new System.Drawing.Size(192, 23);
            this.labelSO_6.TabIndex = 106;
            this.labelSO_6.Text = "Param";
            // 
            // labelSO_5
            // 
            this.labelSO_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_5.Location = new System.Drawing.Point(421, 193);
            this.labelSO_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_5.Name = "labelSO_5";
            this.labelSO_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_5.Size = new System.Drawing.Size(192, 23);
            this.labelSO_5.TabIndex = 105;
            this.labelSO_5.Text = "Param";
            // 
            // textBoxParamSO_6
            // 
            this.textBoxParamSO_6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxParamSO_6.Enabled = false;
            this.textBoxParamSO_6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_6.Location = new System.Drawing.Point(332, 216);
            this.textBoxParamSO_6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_6.Name = "textBoxParamSO_6";
            this.textBoxParamSO_6.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_6.TabIndex = 104;
            // 
            // textBoxThreadsSO_6
            // 
            this.textBoxThreadsSO_6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_6.Location = new System.Drawing.Point(270, 216);
            this.textBoxThreadsSO_6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_6.Name = "textBoxThreadsSO_6";
            this.textBoxThreadsSO_6.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_6.TabIndex = 103;
            // 
            // textBoxParamSO_5
            // 
            this.textBoxParamSO_5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxParamSO_5.Enabled = false;
            this.textBoxParamSO_5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_5.Location = new System.Drawing.Point(332, 186);
            this.textBoxParamSO_5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_5.Name = "textBoxParamSO_5";
            this.textBoxParamSO_5.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_5.TabIndex = 102;
            // 
            // textBoxThreadsSO_5
            // 
            this.textBoxThreadsSO_5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_5.Location = new System.Drawing.Point(270, 186);
            this.textBoxThreadsSO_5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_5.Name = "textBoxThreadsSO_5";
            this.textBoxThreadsSO_5.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_5.TabIndex = 101;
            // 
            // checkBoxSO_4
            // 
            this.checkBoxSO_4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_4.Location = new System.Drawing.Point(24, 159);
            this.checkBoxSO_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_4.Name = "checkBoxSO_4";
            this.checkBoxSO_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_4.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_4.TabIndex = 100;
            this.checkBoxSO_4.Text = "Load Scenario #4";
            this.checkBoxSO_4.UseVisualStyleBackColor = true;
            // 
            // checkBoxSO_3
            // 
            this.checkBoxSO_3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_3.Location = new System.Drawing.Point(24, 130);
            this.checkBoxSO_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_3.Name = "checkBoxSO_3";
            this.checkBoxSO_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_3.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_3.TabIndex = 99;
            this.checkBoxSO_3.Text = "Load Scenario #3";
            this.checkBoxSO_3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSO_2
            // 
            this.checkBoxSO_2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_2.Location = new System.Drawing.Point(24, 102);
            this.checkBoxSO_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_2.Name = "checkBoxSO_2";
            this.checkBoxSO_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_2.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_2.TabIndex = 98;
            this.checkBoxSO_2.Text = "Load Scenario #2";
            this.checkBoxSO_2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSO_1
            // 
            this.checkBoxSO_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_1.Location = new System.Drawing.Point(24, 72);
            this.checkBoxSO_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_1.Name = "checkBoxSO_1";
            this.checkBoxSO_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_1.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_1.TabIndex = 97;
            this.checkBoxSO_1.Text = "Load Scenario #1";
            this.checkBoxSO_1.UseVisualStyleBackColor = true;
            // 
            // labelSO_4
            // 
            this.labelSO_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_4.Location = new System.Drawing.Point(421, 163);
            this.labelSO_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_4.Name = "labelSO_4";
            this.labelSO_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_4.Size = new System.Drawing.Size(192, 23);
            this.labelSO_4.TabIndex = 95;
            this.labelSO_4.Text = "Param";
            // 
            // labelSO_3
            // 
            this.labelSO_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_3.Location = new System.Drawing.Point(421, 134);
            this.labelSO_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_3.Name = "labelSO_3";
            this.labelSO_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_3.Size = new System.Drawing.Size(192, 23);
            this.labelSO_3.TabIndex = 94;
            this.labelSO_3.Text = "Param";
            // 
            // labelSO_2
            // 
            this.labelSO_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_2.Location = new System.Drawing.Point(421, 105);
            this.labelSO_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_2.Name = "labelSO_2";
            this.labelSO_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_2.Size = new System.Drawing.Size(177, 23);
            this.labelSO_2.TabIndex = 93;
            this.labelSO_2.Text = "Param";
            // 
            // labelSO_1
            // 
            this.labelSO_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_1.Location = new System.Drawing.Point(421, 76);
            this.labelSO_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_1.Name = "labelSO_1";
            this.labelSO_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_1.Size = new System.Drawing.Size(192, 23);
            this.labelSO_1.TabIndex = 92;
            this.labelSO_1.Text = "Param";
            // 
            // labelSO_0
            // 
            this.labelSO_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSO_0.Location = new System.Drawing.Point(421, 44);
            this.labelSO_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSO_0.Name = "labelSO_0";
            this.labelSO_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO_0.Size = new System.Drawing.Size(192, 23);
            this.labelSO_0.TabIndex = 91;
            this.labelSO_0.Text = "Param";
            // 
            // textBoxParamSO_4
            // 
            this.textBoxParamSO_4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxParamSO_4.Enabled = false;
            this.textBoxParamSO_4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_4.Location = new System.Drawing.Point(332, 156);
            this.textBoxParamSO_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_4.Name = "textBoxParamSO_4";
            this.textBoxParamSO_4.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_4.TabIndex = 86;
            // 
            // textBoxThreadsSO_4
            // 
            this.textBoxThreadsSO_4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_4.Location = new System.Drawing.Point(270, 156);
            this.textBoxThreadsSO_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_4.Name = "textBoxThreadsSO_4";
            this.textBoxThreadsSO_4.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_4.TabIndex = 85;
            // 
            // textBoxParamSO_3
            // 
            this.textBoxParamSO_3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_3.Location = new System.Drawing.Point(332, 127);
            this.textBoxParamSO_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_3.Name = "textBoxParamSO_3";
            this.textBoxParamSO_3.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_3.TabIndex = 84;
            // 
            // textBoxThreadsSO_3
            // 
            this.textBoxThreadsSO_3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_3.Location = new System.Drawing.Point(270, 127);
            this.textBoxThreadsSO_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_3.Name = "textBoxThreadsSO_3";
            this.textBoxThreadsSO_3.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_3.TabIndex = 83;
            // 
            // checkBoxSO_0
            // 
            this.checkBoxSO_0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxSO_0.Location = new System.Drawing.Point(24, 43);
            this.checkBoxSO_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSO_0.Name = "checkBoxSO_0";
            this.checkBoxSO_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSO_0.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSO_0.TabIndex = 79;
            this.checkBoxSO_0.Text = "Load Scenario #0";
            this.checkBoxSO_0.UseVisualStyleBackColor = true;
            // 
            // textBoxParamSO_2
            // 
            this.textBoxParamSO_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_2.Location = new System.Drawing.Point(332, 98);
            this.textBoxParamSO_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_2.Name = "textBoxParamSO_2";
            this.textBoxParamSO_2.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_2.TabIndex = 78;
            // 
            // textBoxThreadsSO_2
            // 
            this.textBoxThreadsSO_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_2.Location = new System.Drawing.Point(270, 98);
            this.textBoxThreadsSO_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_2.Name = "textBoxThreadsSO_2";
            this.textBoxThreadsSO_2.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_2.TabIndex = 77;
            // 
            // textBoxParamSO_1
            // 
            this.textBoxParamSO_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_1.Location = new System.Drawing.Point(332, 69);
            this.textBoxParamSO_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_1.Name = "textBoxParamSO_1";
            this.textBoxParamSO_1.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_1.TabIndex = 74;
            // 
            // textBoxThreadsSO_1
            // 
            this.textBoxThreadsSO_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_1.Location = new System.Drawing.Point(270, 69);
            this.textBoxThreadsSO_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_1.Name = "textBoxThreadsSO_1";
            this.textBoxThreadsSO_1.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_1.TabIndex = 73;
            // 
            // textBoxParamSO_0
            // 
            this.textBoxParamSO_0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamSO_0.Location = new System.Drawing.Point(332, 40);
            this.textBoxParamSO_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamSO_0.Name = "textBoxParamSO_0";
            this.textBoxParamSO_0.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamSO_0.TabIndex = 72;
            // 
            // textBoxThreadsSO_0
            // 
            this.textBoxThreadsSO_0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsSO_0.Location = new System.Drawing.Point(270, 40);
            this.textBoxThreadsSO_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsSO_0.Name = "textBoxThreadsSO_0";
            this.textBoxThreadsSO_0.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsSO_0.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNH_3);
            this.groupBox1.Controls.Add(this.labelNH_2);
            this.groupBox1.Controls.Add(this.labelNH_1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelNH_0);
            this.groupBox1.Controls.Add(this.textBoxParamNH_3);
            this.groupBox1.Controls.Add(this.textBoxThreadsNH_3);
            this.groupBox1.Controls.Add(this.checkBoxNH_3);
            this.groupBox1.Controls.Add(this.checkBoxNH_0);
            this.groupBox1.Controls.Add(this.textBoxParamNH_2);
            this.groupBox1.Controls.Add(this.textBoxThreadsNH_2);
            this.groupBox1.Controls.Add(this.checkBoxNH_2);
            this.groupBox1.Controls.Add(this.checkBoxNH_1);
            this.groupBox1.Controls.Add(this.textBoxParamNH_1);
            this.groupBox1.Controls.Add(this.textBoxThreadsNH_1);
            this.groupBox1.Controls.Add(this.textBoxParamNH_0);
            this.groupBox1.Controls.Add(this.textBoxThreadsNH_0);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(622, 193);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " On Tests Database ";
            // 
            // labelNH_3
            // 
            this.labelNH_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNH_3.Location = new System.Drawing.Point(421, 144);
            this.labelNH_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNH_3.Name = "labelNH_3";
            this.labelNH_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNH_3.Size = new System.Drawing.Size(192, 23);
            this.labelNH_3.TabIndex = 67;
            this.labelNH_3.Text = "Param";
            // 
            // labelNH_2
            // 
            this.labelNH_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNH_2.Location = new System.Drawing.Point(421, 119);
            this.labelNH_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNH_2.Name = "labelNH_2";
            this.labelNH_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNH_2.Size = new System.Drawing.Size(177, 23);
            this.labelNH_2.TabIndex = 66;
            this.labelNH_2.Text = "Param";
            // 
            // labelNH_1
            // 
            this.labelNH_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNH_1.Location = new System.Drawing.Point(421, 90);
            this.labelNH_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNH_1.Name = "labelNH_1";
            this.labelNH_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNH_1.Size = new System.Drawing.Size(177, 23);
            this.labelNH_1.TabIndex = 65;
            this.labelNH_1.Text = "Param";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(344, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Param";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(270, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Threads";
            // 
            // labelNH_0
            // 
            this.labelNH_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNH_0.Location = new System.Drawing.Point(421, 61);
            this.labelNH_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNH_0.Name = "labelNH_0";
            this.labelNH_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNH_0.Size = new System.Drawing.Size(192, 23);
            this.labelNH_0.TabIndex = 59;
            this.labelNH_0.Text = "Param";
            // 
            // textBoxParamNH_3
            // 
            this.textBoxParamNH_3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamNH_3.Location = new System.Drawing.Point(332, 141);
            this.textBoxParamNH_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamNH_3.Name = "textBoxParamNH_3";
            this.textBoxParamNH_3.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamNH_3.TabIndex = 58;
            // 
            // textBoxThreadsNH_3
            // 
            this.textBoxThreadsNH_3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsNH_3.Location = new System.Drawing.Point(270, 141);
            this.textBoxThreadsNH_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsNH_3.Name = "textBoxThreadsNH_3";
            this.textBoxThreadsNH_3.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsNH_3.TabIndex = 57;
            // 
            // checkBoxNH_3
            // 
            this.checkBoxNH_3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxNH_3.Location = new System.Drawing.Point(24, 143);
            this.checkBoxNH_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNH_3.Name = "checkBoxNH_3";
            this.checkBoxNH_3.Size = new System.Drawing.Size(238, 24);
            this.checkBoxNH_3.TabIndex = 56;
            this.checkBoxNH_3.Text = "Load Scenario #3";
            this.checkBoxNH_3.UseVisualStyleBackColor = true;
            // 
            // checkBoxNH_0
            // 
            this.checkBoxNH_0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxNH_0.Location = new System.Drawing.Point(24, 57);
            this.checkBoxNH_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNH_0.Name = "checkBoxNH_0";
            this.checkBoxNH_0.Size = new System.Drawing.Size(238, 24);
            this.checkBoxNH_0.TabIndex = 55;
            this.checkBoxNH_0.Text = "Load Scenario #0";
            this.checkBoxNH_0.UseVisualStyleBackColor = true;
            // 
            // textBoxParamNH_2
            // 
            this.textBoxParamNH_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamNH_2.Location = new System.Drawing.Point(332, 112);
            this.textBoxParamNH_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamNH_2.Name = "textBoxParamNH_2";
            this.textBoxParamNH_2.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamNH_2.TabIndex = 54;
            // 
            // textBoxThreadsNH_2
            // 
            this.textBoxThreadsNH_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsNH_2.Location = new System.Drawing.Point(270, 112);
            this.textBoxThreadsNH_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsNH_2.Name = "textBoxThreadsNH_2";
            this.textBoxThreadsNH_2.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsNH_2.TabIndex = 53;
            // 
            // checkBoxNH_2
            // 
            this.checkBoxNH_2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxNH_2.Location = new System.Drawing.Point(24, 114);
            this.checkBoxNH_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNH_2.Name = "checkBoxNH_2";
            this.checkBoxNH_2.Size = new System.Drawing.Size(238, 24);
            this.checkBoxNH_2.TabIndex = 52;
            this.checkBoxNH_2.Text = "Load Scenario #2";
            this.checkBoxNH_2.UseVisualStyleBackColor = true;
            // 
            // checkBoxNH_1
            // 
            this.checkBoxNH_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxNH_1.Location = new System.Drawing.Point(24, 87);
            this.checkBoxNH_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNH_1.Name = "checkBoxNH_1";
            this.checkBoxNH_1.Size = new System.Drawing.Size(238, 24);
            this.checkBoxNH_1.TabIndex = 51;
            this.checkBoxNH_1.Text = "Load Scenario #1";
            this.checkBoxNH_1.UseVisualStyleBackColor = true;
            // 
            // textBoxParamNH_1
            // 
            this.textBoxParamNH_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxParamNH_1.Enabled = false;
            this.textBoxParamNH_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamNH_1.Location = new System.Drawing.Point(332, 83);
            this.textBoxParamNH_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamNH_1.Name = "textBoxParamNH_1";
            this.textBoxParamNH_1.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamNH_1.TabIndex = 50;
            // 
            // textBoxThreadsNH_1
            // 
            this.textBoxThreadsNH_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsNH_1.Location = new System.Drawing.Point(270, 83);
            this.textBoxThreadsNH_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsNH_1.Name = "textBoxThreadsNH_1";
            this.textBoxThreadsNH_1.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsNH_1.TabIndex = 49;
            // 
            // textBoxParamNH_0
            // 
            this.textBoxParamNH_0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxParamNH_0.Location = new System.Drawing.Point(332, 54);
            this.textBoxParamNH_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParamNH_0.Name = "textBoxParamNH_0";
            this.textBoxParamNH_0.Size = new System.Drawing.Size(81, 27);
            this.textBoxParamNH_0.TabIndex = 48;
            // 
            // textBoxThreadsNH_0
            // 
            this.textBoxThreadsNH_0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxThreadsNH_0.Location = new System.Drawing.Point(270, 54);
            this.textBoxThreadsNH_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxThreadsNH_0.Name = "textBoxThreadsNH_0";
            this.textBoxThreadsNH_0.Size = new System.Drawing.Size(54, 27);
            this.textBoxThreadsNH_0.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(38, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(141, 55);
            this.label8.TabIndex = 27;
            this.label8.Text = "Load";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.LightSalmon;
            this.GoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))),
                ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.GoButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GoButton.ForeColor = System.Drawing.Color.Black;
            this.GoButton.Location = new System.Drawing.Point(217, 560);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(304, 57);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (13)))), ((int) (((byte) (13)))),
                ((int) (((byte) (55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(941, 668);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonSQLConnect;
        private System.Windows.Forms.Button NHbuttonAdd;
        private System.Windows.Forms.Button NHbuttonGet;
        private System.Windows.Forms.TextBox TextBoxBlogId;
        private System.Windows.Forms.Button NHbuttonGetById;
        private System.Windows.Forms.Button NHbuttonUpdate;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NHGetBlogsCount;
        private System.Windows.Forms.Button NHbuttonDelete;
        private System.Windows.Forms.Button NHGetBlogFromPost;
        private System.Windows.Forms.Button NHButtonRawQuery;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button asyncButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNH_1;
        private System.Windows.Forms.Label labelNH_2;
        private System.Windows.Forms.Label labelNH_3;
        private System.Windows.Forms.CheckBox checkBoxSO_1;
        private System.Windows.Forms.CheckBox checkBoxNH_1;
        private System.Windows.Forms.CheckBox checkBoxNH_2;
        private System.Windows.Forms.CheckBox checkBoxNH_0;
        private System.Windows.Forms.CheckBox checkBoxNH_3;
        private System.Windows.Forms.Label labelNH_0;
        private System.Windows.Forms.CheckBox checkBoxSO_0;
        private System.Windows.Forms.CheckBox checkBoxSO_4;
        private System.Windows.Forms.CheckBox checkBoxSO_3;
        private System.Windows.Forms.CheckBox checkBoxSO_2;
        private System.Windows.Forms.CheckBox checkBoxSO_6;
        private System.Windows.Forms.CheckBox checkBoxSO_5;
        private System.Windows.Forms.Label labelSO_6;
        private System.Windows.Forms.Label labelSO_5;
        private System.Windows.Forms.Label labelSO_3;
        private System.Windows.Forms.Label labelSO_4;
        private System.Windows.Forms.Label labelSO_0;
        private System.Windows.Forms.Label labelSO_1;
        private System.Windows.Forms.Label labelSO_2;
        private System.Windows.Forms.TextBox textBoxThreadsNH_0;
        private System.Windows.Forms.TextBox textBoxThreadsSO_1;
        private System.Windows.Forms.TextBox textBoxParamNH_3;
        private System.Windows.Forms.TextBox textBoxThreadsNH_3;
        private System.Windows.Forms.TextBox textBoxParamNH_2;
        private System.Windows.Forms.TextBox textBoxThreadsNH_2;
        private System.Windows.Forms.TextBox textBoxThreadsNH_1;
        private System.Windows.Forms.TextBox textBoxParamNH_1;
        private System.Windows.Forms.TextBox textBoxParamNH_0;
        private System.Windows.Forms.TextBox textBoxParamSO_6;
        private System.Windows.Forms.TextBox textBoxThreadsSO_6;
        private System.Windows.Forms.TextBox textBoxParamSO_5;
        private System.Windows.Forms.TextBox textBoxThreadsSO_5;
        private System.Windows.Forms.TextBox textBoxParamSO_4;
        private System.Windows.Forms.TextBox textBoxThreadsSO_4;
        private System.Windows.Forms.TextBox textBoxParamSO_3;
        private System.Windows.Forms.TextBox textBoxThreadsSO_3;
        private System.Windows.Forms.TextBox textBoxParamSO_2;
        private System.Windows.Forms.TextBox textBoxThreadsSO_2;
        private System.Windows.Forms.TextBox textBoxParamSO_1;
        private System.Windows.Forms.TextBox textBoxParamSO_0;
        private System.Windows.Forms.TextBox textBoxThreadsSO_0;
    }
}

