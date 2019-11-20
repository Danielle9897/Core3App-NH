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
            this.buttonSQLConnect = new System.Windows.Forms.Button();
            this.NHbuttonAdd = new System.Windows.Forms.Button();
            this.NHbuttonGet = new System.Windows.Forms.Button();
            this.NHGetBlogsCount = new System.Windows.Forms.Button();
            this.NHButtonRawQuery = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.NHbuttonUpdate = new System.Windows.Forms.Button();
            this.NHbuttonGetById = new System.Windows.Forms.Button();
            this.TextBoxBlogId = new System.Windows.Forms.TextBox();
            this.NHbuttonDelete = new System.Windows.Forms.Button();
            this.NHGetBlogFromPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.asyncButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSQLConnect
            // 
            this.buttonSQLConnect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSQLConnect.Location = new System.Drawing.Point(28, 679);
            this.buttonSQLConnect.Name = "buttonSQLConnect";
            this.buttonSQLConnect.Size = new System.Drawing.Size(196, 40);
            this.buttonSQLConnect.TabIndex = 1;
            this.buttonSQLConnect.Text = "Connect with SqlConnection\r\n";
            this.buttonSQLConnect.UseVisualStyleBackColor = false;
            this.buttonSQLConnect.Click += new System.EventHandler(this.buttonSQLConnect_Click);
            // 
            // NHbuttonAdd
            // 
            this.NHbuttonAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonAdd.Location = new System.Drawing.Point(17, 24);
            this.NHbuttonAdd.Name = "NHbuttonAdd";
            this.NHbuttonAdd.Size = new System.Drawing.Size(376, 40);
            this.NHbuttonAdd.TabIndex = 1;
            this.NHbuttonAdd.Text = "NH - Add new Blog";
            this.NHbuttonAdd.UseVisualStyleBackColor = false;
            this.NHbuttonAdd.Click += new System.EventHandler(this.NHbuttonAdd_Click);
            // 
            // NHbuttonGet
            // 
            this.NHbuttonGet.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonGet.Location = new System.Drawing.Point(17, 115);
            this.NHbuttonGet.Name = "NHbuttonGet";
            this.NHbuttonGet.Size = new System.Drawing.Size(376, 40);
            this.NHbuttonGet.TabIndex = 3;
            this.NHbuttonGet.Text = "NH - Get all Blogs";
            this.NHbuttonGet.UseVisualStyleBackColor = false;
            this.NHbuttonGet.Click += new System.EventHandler(this.NHbuttonGetAllBlogs_Click);
            // 
            // NHGetBlogsCount
            // 
            this.NHGetBlogsCount.BackColor = System.Drawing.Color.LightSalmon;
            this.NHGetBlogsCount.Location = new System.Drawing.Point(17, 70);
            this.NHGetBlogsCount.Name = "NHGetBlogsCount";
            this.NHGetBlogsCount.Size = new System.Drawing.Size(376, 40);
            this.NHGetBlogsCount.TabIndex = 8;
            this.NHGetBlogsCount.Text = "NH - Get Blogs Count - with CreateQuery\r\n";
            this.NHGetBlogsCount.UseVisualStyleBackColor = false;
            this.NHGetBlogsCount.Click += new System.EventHandler(this.NHGetBlogsCount_Click);
            // 
            // NHButtonRawQuery
            // 
            this.NHButtonRawQuery.BackColor = System.Drawing.Color.LightSalmon;
            this.NHButtonRawQuery.Location = new System.Drawing.Point(17, 19);
            this.NHButtonRawQuery.Name = "NHButtonRawQuery";
            this.NHButtonRawQuery.Size = new System.Drawing.Size(377, 40);
            this.NHButtonRawQuery.TabIndex = 9;
            this.NHButtonRawQuery.Text = "NH - Raw Query on Blogs Table";
            this.NHButtonRawQuery.UseVisualStyleBackColor = false;
            this.NHButtonRawQuery.Click += new System.EventHandler(this.NHButtonRawQuery_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(18, 65);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(376, 50);
            this.QueryTextBox.TabIndex = 10;
            // 
            // NHbuttonUpdate
            // 
            this.NHbuttonUpdate.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonUpdate.Location = new System.Drawing.Point(17, 68);
            this.NHbuttonUpdate.Name = "NHbuttonUpdate";
            this.NHbuttonUpdate.Size = new System.Drawing.Size(296, 40);
            this.NHbuttonUpdate.TabIndex = 4;
            this.NHbuttonUpdate.Text = "NH - Update \'Created At\' column";
            this.NHbuttonUpdate.UseVisualStyleBackColor = false;
            this.NHbuttonUpdate.Click += new System.EventHandler(this.NHbuttonUpdate_Click);
            // 
            // NHbuttonGetById
            // 
            this.NHbuttonGetById.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonGetById.Location = new System.Drawing.Point(17, 22);
            this.NHbuttonGetById.Name = "NHbuttonGetById";
            this.NHbuttonGetById.Size = new System.Drawing.Size(296, 40);
            this.NHbuttonGetById.TabIndex = 4;
            this.NHbuttonGetById.Text = "NH - Get Blog by ID\r\n";
            this.NHbuttonGetById.UseVisualStyleBackColor = false;
            this.NHbuttonGetById.Click += new System.EventHandler(this.NHbuttonGetById_Click);
            // 
            // TextBoxBlogId
            // 
            this.TextBoxBlogId.Location = new System.Drawing.Point(349, 107);
            this.TextBoxBlogId.Name = "TextBoxBlogId";
            this.TextBoxBlogId.Size = new System.Drawing.Size(84, 23);
            this.TextBoxBlogId.TabIndex = 5;
            // 
            // NHbuttonDelete
            // 
            this.NHbuttonDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.NHbuttonDelete.Location = new System.Drawing.Point(17, 117);
            this.NHbuttonDelete.Name = "NHbuttonDelete";
            this.NHbuttonDelete.Size = new System.Drawing.Size(296, 40);
            this.NHbuttonDelete.TabIndex = 6;
            this.NHbuttonDelete.Text = "NH - Delete Blog\r\n";
            this.NHbuttonDelete.UseVisualStyleBackColor = false;
            this.NHbuttonDelete.Click += new System.EventHandler(this.NHbuttonDelete_Click);
            // 
            // NHGetBlogFromPost
            // 
            this.NHGetBlogFromPost.BackColor = System.Drawing.Color.LightSalmon;
            this.NHGetBlogFromPost.Location = new System.Drawing.Point(17, 165);
            this.NHGetBlogFromPost.Name = "NHGetBlogFromPost";
            this.NHGetBlogFromPost.Size = new System.Drawing.Size(296, 40);
            this.NHGetBlogFromPost.TabIndex = 7;
            this.NHGetBlogFromPost.Text = "NH - Get Blog from Post";
            this.NHGetBlogFromPost.UseVisualStyleBackColor = false;
            this.NHGetBlogFromPost.Click += new System.EventHandler(this.NHGetBlogFromPost_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(334, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.NHbuttonGetById);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NHbuttonUpdate);
            this.panel1.Controls.Add(this.TextBoxBlogId);
            this.panel1.Controls.Add(this.NHbuttonDelete);
            this.panel1.Controls.Add(this.NHGetBlogFromPost);
            this.panel1.Location = new System.Drawing.Point(28, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 217);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (157)))), ((int) (((byte) (157)))),
                ((int) (((byte) (157)))));
            this.panel2.Controls.Add(this.NHButtonRawQuery);
            this.panel2.Controls.Add(this.QueryTextBox);
            this.panel2.Location = new System.Drawing.Point(28, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 134);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))),
                ((int) (((byte) (215)))));
            this.panel3.Controls.Add(this.NHbuttonAdd);
            this.panel3.Controls.Add(this.NHbuttonGet);
            this.panel3.Controls.Add(this.NHGetBlogsCount);
            this.panel3.Location = new System.Drawing.Point(28, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 172);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))),
                ((int) (((byte) (215)))));
            this.panel4.Controls.Add(this.asyncButton);
            this.panel4.Location = new System.Drawing.Point(28, 585);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 78);
            this.panel4.TabIndex = 15;
            // 
            // asyncButton
            // 
            this.asyncButton.BackColor = System.Drawing.Color.LightSalmon;
            this.asyncButton.Location = new System.Drawing.Point(17, 16);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(376, 40);
            this.asyncButton.TabIndex = 0;
            this.asyncButton.Text = "NH - Async";
            this.asyncButton.UseVisualStyleBackColor = false;
            this.asyncButton.Click += new System.EventHandler(this.asyncButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(526, 741);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSQLConnect);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
    }
}

