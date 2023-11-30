namespace UnrealSharpInspector
{
    partial class Form_Inspector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            DumpSDK = new Button();
            ActorInfo = new ListBox();
            DumpActorList = new Button();
            ActorList = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // DumpSDK
            // 
            DumpSDK.BackColor = Color.FromArgb(35, 35, 35);
            DumpSDK.FlatAppearance.BorderColor = Color.Gray;
            DumpSDK.FlatStyle = FlatStyle.Flat;
            DumpSDK.ForeColor = Color.White;
            DumpSDK.Location = new Point(10, 378);
            DumpSDK.Name = "DumpSDK";
            DumpSDK.Size = new Size(301, 26);
            DumpSDK.TabIndex = 0;
            DumpSDK.Text = "Dump SDK";
            DumpSDK.UseVisualStyleBackColor = false;
            DumpSDK.Click += DumpSDK_Click;
            // 
            // ActorInfo
            // 
            ActorInfo.BackColor = Color.FromArgb(35, 35, 35);
            ActorInfo.BorderStyle = BorderStyle.FixedSingle;
            ActorInfo.ForeColor = Color.White;
            ActorInfo.FormattingEnabled = true;
            ActorInfo.ItemHeight = 15;
            ActorInfo.Location = new Point(318, 42);
            ActorInfo.Name = "ActorInfo";
            ActorInfo.Size = new Size(455, 362);
            ActorInfo.TabIndex = 1;
            ActorInfo.SelectedIndexChanged += ActorInfo_SelectedIndexChanged;
            // 
            // DumpActorList
            // 
            DumpActorList.BackColor = Color.FromArgb(35, 35, 35);
            DumpActorList.FlatAppearance.BorderColor = Color.Gray;
            DumpActorList.FlatStyle = FlatStyle.Flat;
            DumpActorList.ForeColor = Color.White;
            DumpActorList.Location = new Point(10, 346);
            DumpActorList.Name = "DumpActorList";
            DumpActorList.Size = new Size(301, 26);
            DumpActorList.TabIndex = 2;
            DumpActorList.Text = "Dump Actor List";
            DumpActorList.UseVisualStyleBackColor = false;
            DumpActorList.Click += DumpActorList_Click;
            // 
            // ActorList
            // 
            ActorList.BackColor = Color.FromArgb(35, 35, 35);
            ActorList.BorderStyle = BorderStyle.FixedSingle;
            ActorList.ForeColor = Color.White;
            ActorList.FormattingEnabled = true;
            ActorList.ItemHeight = 15;
            ActorList.Location = new Point(10, 42);
            ActorList.Name = "ActorList";
            ActorList.Size = new Size(301, 272);
            ActorList.TabIndex = 3;
            ActorList.SelectedIndexChanged += ActorList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(301, 15);
            label2.TabIndex = 6;
            label2.Text = "Actor List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 15);
            label1.Name = "label1";
            label1.Size = new Size(455, 15);
            label1.TabIndex = 7;
            label1.Text = "Actor Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 322);
            label3.Name = "label3";
            label3.Size = new Size(301, 15);
            label3.TabIndex = 8;
            label3.Text = "Addons";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Inspector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(784, 414);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(ActorList);
            Controls.Add(DumpActorList);
            Controls.Add(ActorInfo);
            Controls.Add(DumpSDK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Inspector";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UE Inspector [by iBadassCheats]";
            Load += Form_Inspector_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button DumpSDK;
        private ListBox ActorInfo;
        private Button DumpActorList;
        private ListBox ActorList;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}