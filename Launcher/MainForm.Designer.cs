namespace Launcher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.CheckBox chkIamQa;
        private System.Windows.Forms.CheckBox chkIamShuruk;
        private System.Windows.Forms.CheckBox chkDevInfo;
        private System.Windows.Forms.CheckBox chkWriteConfig;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUserId = new System.Windows.Forms.Label();
            txtUserId = new System.Windows.Forms.TextBox();
            chkIamQa = new System.Windows.Forms.CheckBox();
            chkIamShuruk = new System.Windows.Forms.CheckBox();
            chkDevInfo = new System.Windows.Forms.CheckBox();
            chkWriteConfig = new System.Windows.Forms.CheckBox();
            btnStart = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new System.Drawing.Point(20, 24);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new System.Drawing.Size(47, 15);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "계정 ID";
            // 
            // txtUserId
            // 
            txtUserId.Location = new System.Drawing.Point(82, 20);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(158, 23);
            txtUserId.TabIndex = 1;
            // 
            // chkIamQa
            // 
            chkIamQa.AutoSize = true;
            chkIamQa.Checked = true;
            chkIamQa.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIamQa.Location = new System.Drawing.Point(20, 58);
            chkIamQa.Name = "chkIamQa";
            chkIamQa.Size = new System.Drawing.Size(220, 19);
            chkIamQa.TabIndex = 2;
            chkIamQa.Text = "iamqa 활성화 (QA 서버리스트 사용)";
            chkIamQa.UseVisualStyleBackColor = true;
            // 
            // chkIamShuruk
            // 
            chkIamShuruk.AutoSize = true;
            chkIamShuruk.Checked = true;
            chkIamShuruk.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIamShuruk.Location = new System.Drawing.Point(20, 83);
            chkIamShuruk.Name = "chkIamShuruk";
            chkIamShuruk.Size = new System.Drawing.Size(122, 19);
            chkIamShuruk.TabIndex = 3;
            chkIamShuruk.Text = "iamshuruk 활성화";
            chkIamShuruk.UseVisualStyleBackColor = true;
            // 
            // chkDevInfo
            // 
            chkDevInfo.AutoSize = true;
            chkDevInfo.Checked = true;
            chkDevInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDevInfo.Location = new System.Drawing.Point(20, 108);
            chkDevInfo.Name = "chkDevInfo";
            chkDevInfo.Size = new System.Drawing.Size(143, 19);
            chkDevInfo.TabIndex = 4;
            chkDevInfo.Text = "enableDevInfo 활성화";
            chkDevInfo.UseVisualStyleBackColor = true;
            // 
            // chkWriteConfig
            // 
            chkWriteConfig.AutoSize = true;
            chkWriteConfig.Checked = true;
            chkWriteConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            chkWriteConfig.Location = new System.Drawing.Point(20, 133);
            chkWriteConfig.Name = "chkWriteConfig";
            chkWriteConfig.Size = new System.Drawing.Size(212, 19);
            chkWriteConfig.TabIndex = 5;
            chkWriteConfig.Text = "실행 전 config.xml 자동 생성/갱신";
            chkWriteConfig.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(20, 170);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(130, 35);
            btnStart.TabIndex = 6;
            btnStart.Text = "게임 실행";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(156, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(84, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "설정 저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(270, 225);
            Controls.Add(btnSave);
            Controls.Add(btnStart);
            Controls.Add(chkWriteConfig);
            Controls.Add(chkDevInfo);
            Controls.Add(chkIamShuruk);
            Controls.Add(chkIamQa);
            Controls.Add(txtUserId);
            Controls.Add(lblUserId);
            Font = new System.Drawing.Font("맑은 고딕", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Launcher";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
